# How To Utilize IronWord on Azure with .NET

***Based on <https://ironsoftware.com/get-started/azure/>***


IronWord is a robust .NET library designed to programmatically create, edit, and review Word documents. It integrates smoothly with multiple Azure services, including Azure App Services, Azure Functions, and Azure Container Instances.

## Setting up IronWord

First, add the IronWord NuGet package to your project by installing it from the NuGet repository:

```shell
Install-Package IronWord
```

## Considerations for Azure Hosting

### Selecting an Appropriate Azure Service Plan

IronWord operates optimally on Azure service tiers that ensure steady computational resources. The Basic (B1) App Service Plan generally suffices for small to medium applications. For applications that manage a substantial volume of Word documents or engage in intricate formatting operations, it's advisable to opt for the Standard (S1) tier or higher to prevent performance lag.

### Compatibility and Supported .NET Frameworks

IronWord is readily compatible with the frameworks often used in Azure-hosted environments:

- .NET 6+ (LTS recommended)
- .NET Core 3.1
- .NET Standard 2.1

These options ensure that IronWord can be deployed across different Azure offerings like App Services, Azure Functions, and Docker containers seamlessly.

## Deploying IronWord in Docker Containers on Azure

### Using IronWord in Containerized Environments

Deploying IronWord within a Docker container leveraging Azure Container Instances (ACI) or Azure Kubernetes Service (AKS) provides enhanced control over the environment, allowing configurations such as:

- Pre-loading necessary templates or resources
- Customizing document processing settings
- Optimizing performance at the operating system level

Start with a base image like `mcr.microsoft.com/dotnet/aspnet:6.0` or `7.0` and incorporate IronWord via NuGet or by adding the DLL manually.

## Serverless Deployment via Azure Functions

### Implementing IronWord with Azure Functions

With compatibility for Azure Functions v4 running on .NET 6 or later, IronWord is perfect for lightweight, event-driven, on-demand document processing scenarios such as:

- On-demand report generation through HTTP triggers
- Document creation from form data submissions
- Transforming structured data into `.docx` files

## Example Scenario in Azure Functions: Generating a Word Document from an HTTP Request

Here’s a practical example where an Azure Function generates a Word document upon receiving an HTTP request:

```csharp
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using IronWord;
using IronWord.Models;
using System.IO;
using System.Threading.Tasks;

public static class DocumentGenerator
{
    [FunctionName("CreateWordDocument")]
    public static HttpResponseMessage Generate(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("Initiating document generation process...");

        // Set the IronWord license
        IronWord.License.LicenseKey = "YOUR-LICENSE-KEY";

        // Generate the Word document
        var doc = new WordDocument();
        Paragraph introParagraph = new Paragraph(new TextContent("This document was dynamically generated using IronWord."));
        Paragraph timeParagraph = new Paragraph(new TextContent($"Generated on: {System.DateTime.UtcNow}"));
        doc.AddParagraph(introParagraph);
        doc.AddParagraph(timeParagraph);

        // Save document locally
        string tempFilePath = Path.GetTempFileName().Replace(".tmp", ".docx");
        doc.SaveAs(tempFilePath);

        // Convert to byte array
        byte[] documentBytes = File.ReadAllBytes(tempFilePath);

        // Clean up temporary files
        File.Delete(tempFilePath);

        // Construct response with document attachment
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new ByteArrayContent(documentBytes)
        };
        response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
        {
            FileName = $"DynamicDocument_{System.DateTime.UtcNow:yyyyMMdd_HHmmss}.docx"
        };
        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.wordprocessingml.document");

        return response;
    }
}
```

**Code Breakdown:**

1. The function `CreateWordDocument` is defined and can be triggered by HTTP methods GET or POST.
2. It logs the start of the document creation process.
3. The IronWord license is set.
4. A new `WordDocument` is instantiated and populated with paragraphs.
5. The generated document is then saved to a temporary `.docx` file.
6. The document is read into a byte array, preparing it to be packaged for download.
7. Post-reading, the temporary file is automatically cleaned up.
8. The function creates an `HttpResponseMessage` containing the document bytes, which can be downloaded by clients.
9. It configures headers to manage the download file name and content type, which is specifically set to Word document format.