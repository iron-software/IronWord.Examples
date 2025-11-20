# Utilizing IronWord with AWS Lambda

***Based on <https://ironsoftware.com/get-started/aws/>***


This guide outlines the steps for implementing IronWord in an AWS Lambda environment. By the end of this article, you will know how to configure IronWord to generate and modify Word documents on AWS Lambda.

## Setup Requirements

To begin, you'll need the [AWSSDK.S3 NuGet package](https://www.nuget.org/packages/AWSSDK.S3) because this example involves reading and writing Word documents to an S3 bucket.

## Configuring IronWord ZIP Package for AWS Lambda

AWS Lambda operates with a mostly read-only filesystem, allowing write access only to the `/tmp/` directory. It’s crucial to adjust the IronWord configuration to utilize this directory for its runtime files:

```csharp
var awsTmpDirectory = @"/tmp/";
IronSoftware.Word.Installation.DeploymentPath = awsTmpDirectory;
```

## Setting Up IronWord on AWS

### Creating an AWS Lambda Project

Follow these steps in Visual Studio to set up a containerized AWS Lambda project:

1. Download and install the AWS Toolkit for Visual Studio.
2. Create a new AWS Lambda Project, selecting the .NET Core - C# template.
3. Opt for the .NET 8 (Container Image) blueprint and complete the setup.
4. Choose the container image option for deployment.

### Integrating Necessary Packages

Incorporate both IronWord and AWSSDK.S3 into your project using NuGet. This ensures that IronWord functions effectively within the AWS Lambda environment. Execute the following command to integrate IronWord into your AWS project:

```shell
Install-Package IronWord
```

Adjust your project's Dockerfile to deploy with the .NET 8 Lambda base image and ensure your build artifacts are copied over:

```
FROM public.ecr.aws/lambda/dotnet:8

RUN dnf update -y

WORKDIR /var/task

COPY "bin/Release/lambda-publish"  .
```

### Adapt the Lambda Function Handler

Here’s a sample Lambda function handler that crafts a simple Word document, saves it locally as a `.docx` file, and uploads it to an S3 bucket:

```csharp
using Amazon.Lambda.Core;
using Amazon.S3;
using Amazon.S3.Model;
using IronWord;
using IronWord.Models;
using System.Text;

// Enable JSON serialization of Lambda function's input into a .NET class
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace IronWordAwsLambda;

public class Function
{
    private static readonly IAmazonS3 s3Client = new AmazonS3Client(Amazon.RegionEndpoint.APSoutheast1);

    public async Task FunctionHandler(ILambdaContext context)
    {
        var tempPath = @"/tmp/";
        License.LicenseKey = "YOUR-LICENSE-KEY"; // Update with your license key

        var filename = Guid.NewGuid() + ".docx";
        var localFilePath = Path.Combine(tempPath, filename);
        var bucketName = "your-s3-bucket-name";
        var objectKey = $"IronWordAwsLambda/{filename}";

        try
        {
            // Generate Word Document
            var document = new WordDocument();
            var paragraph = new Paragraph(new TextContent("Hello from IronWord on AWS Lambda!"));
            document.AddParagraph(paragraph);
            document.SaveAs(localFilePath);

            context.Logger.LogLine("Word document successfully created.");

            // Upload the document to S3
            var documentBytes = await File.ReadAllBytesAsync(localFilePath);
            await UploadToS3Async(bucketName, objectKey, documentBytes);

            context.Logger.LogLine($"Document successfully uploaded to S3 at {bucketName}/{objectKey}");
        }
        catch (Exception ex)
        {
            context.Logger.LogLine($"Execution Error: {ex.Message}");
        }
    }

    private async Task UploadToS3Async(string bucketName, string objectKey, byte[] documentBytes)
    {
        using var memoryStream = new MemoryStream(documentBytes);
        var uploadRequest = new PutObjectRequest
        {
            BucketName = bucketName,
            Key = objectKey,
            InputStream = memoryStream,
            ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        };
        await s3Client.PutObjectAsync(uploadRequest);
    }
}
```

### Optimize Memory and Timeout Settings

To ensure adequate performance, set the Lambda function's memory to a minimum of 512 MB and extend the timeout to 300 seconds in your aws-lambda-tools-defaults.json file:

```json
{
  "function-memory-size": 512,
  "function-timeout": 300
}
```

Adjust memory settings as needed, particularly if you encounter errors indicating that the runtime was exited abruptly due to being killed.

### Publishing Your Function

To deploy your Lambda function:
- Right-click on your project in Visual Studio,
- Choose 'Publish to AWS Lambda…',
- Follow the provided steps to configure your deployment.

### Testing Your Setup

Test the Lambda function via the AWS Lambda Console or directly from Visual Studio. After execution, verify if the Word document has been appropriately created and stored in your specified S3 bucket.