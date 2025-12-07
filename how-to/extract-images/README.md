# Extracting Images from DOCX Files Using C# and IronWord

***Based on <https://ironsoftware.com/how-to/extract-images/>***


IronWord simplifies the task of extracting images from Word documents, a frequent need in content migration, media management, and automated document handling. The library provides powerful tools that enable users to save, analyze, or recycle embedded images by exposing their properties like size and format.

The `ExtractImages()` method is a convenient approach to retrieve all images from a document along with their metadata, which is essential for further manipulations and processing.

<h3>Getting Started with IronWord</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Extract Images Example

Using IronWord to extract images from a Word document is efficient and straightforward. We'll use a sample document named "embedded_images.docx" that contains 5 images distributed across three pages. Below is a code example that outlines the primary steps in the image extraction process via the `ExtractImages()` method.

```csharp
using IronWord;

// Initialize the Word document instance
WordDocument document = new WordDocument("embedded_images.docx");

// Retrieve all images from the document
var extractedImages = document.ExtractImages();

// Process each image in the collection
int imageIndex = 0;
foreach (var image in extractedImages)
{
    // Define the filename for saving the image
    string filePath = $"extracted-image-{imageIndex}.png";
    image.SaveAs(filePath);

    Console.WriteLine($"Extracted image {imageIndex}:");
    Console.WriteLine($"Width: {image.Width}px");
    Console.WriteLine($"Height: {image.Height}px");
    Console.WriteLine($"File saved as: {filePath}");

    imageIndex++;
}

Console.WriteLine($"Total extracted images: {imageIndex}");
```

### Sample File ("embedded_images.docx")

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-images/extract-images-sample.webp" alt="Extract images from DOCX" class="img-responsive add-shadow">
    </div>
</div>

### Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-images/extract-images-output.webp" alt="Output of image extraction" class="img-responsive add-shadow">
    </div>
</div>

The extraction retains the original image format, such as .jpg or .png, ensuring that files are saved with adequate extensions. The iteration can cover the whole document or be limited to specific parts, catering to different needs, from personal projects to large-scale enterprise applications.