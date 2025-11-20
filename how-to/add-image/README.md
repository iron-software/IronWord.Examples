# How to Insert an Image into a DOCX File

***Based on <https://ironsoftware.com/how-to/add-image/>***


Integrating images into a Word document (.docx) can significantly enhance its visual appeal and elucidate textual content, such as a sentence or a paragraph. Utilizing IronWord, a C# library tailored for modifying DOCX files, this guide will demonstrate the straightforward process of embedding images within a document in a .NET environment.

### Explore IronWord

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Image Insertion Process

To insert an image into a document, begin by creating an instance of the `ImageContent` class, providing the local path to the image as a string. This `image` instance can then be manipulated throughout the document to adjust attributes like width and height. To embed the image into the document, utilize the `AddImage()` function. After the image is inserted, the document can be saved and exported locally. Below, we depict the process of adding an image directly into the document without attaching it to any specific parent node. Supported image formats include .jpg, .png, .bmp, .tiff, and .gif.

Images can also be integrated as child elements within paragraphs to enhance document structure. This arrangement allows for advanced text formatting and text wrapping settings.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Start by initializing a DOCX file
WordDocument doc = new IronWord.WordDocument();

// Create an image instance
IronWord.Models.ImageContent image = new IronWord.Models.ImageContent("sample-image.jpg");

// Set image properties
image.Width = 200;
image.Height = 200;

// Add the image to the document
doc.AddImage(image);

// Finally, save and export the document
doc.SaveAs("inserted-image.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-image/add-image.webp" alt="Add image" class="img-responsive add-shadow">
    </div>
</div>

## Adding Image via Stream

Adding images from local directories or static URLs is efficiently managed with the previously illustrated method. For images protected by secure APIs that require authentication, utilizing the `Stream` method is the recommended approach. In the following example, an HTTP client sends authorization tokens, retrieves the image as an authenticated stream, and seamlessly adds it to the document before the final export.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Initialize the DOCX file
WordDocument doc = new IronWord.WordDocument();

using (HttpClient client = new HttpClient())
{
    // Set necessary authentication headers
    client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY_HERE");
    client.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");

    // Fetch the image from a secure endpoint
    Stream authenticatedStream = client.GetStreamAsync("https://api.example.com/secure/image.png").Result;
    doc.AddImage(authenticatedStream);
}

// Export the finalized DOCX file
doc.SaveAs("added-image-via-http-stream.docx");

```

## Image Property Customization

IronWord offers several options for customizing image properties.

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Setting</th>
          <th class="tcol2">Description</th>
          <th class="tcol3">Example</th>
      </tr>
      <tr>
          <td>Width</td>
          <td>The horizontal size of the image in pixels</td>
          <td>image.Width = 500;</td>
      </tr>
      <tr>
          <td>Height</td>
          <td>The vertical size of the image in pixels</td>
          <td>image.Height = 300;</td>
      </tr>
      <tr>
          <td>WrapText</td>
          <td>Controls how text wraps around the image</td>
          <td>image.WrapText = WrapText.Square;</td>
      </tr>
      <tr>
          <td>DistanceFromLeft</td>
          <td>Margin from the image to the left boundary in pixels</td>
          <td>image.DistanceFromLeft = 10;</td>
      </tr>
      <tr>
          <td>DistanceFromRight</td>
          <td>Margin from the image to the right boundary in pixels</td>
          <td>image.DistanceFromRight = 10;</td>
      </tr>
      <tr>
          <td>DistanceFromTop</td>
          <td>Margin from the image to the top boundary in pixels</td>
          <td>image.DistanceFromTop = 15;</td>
      </tr>
      <tr>
          <td>DistanceFromBottom</td>
          <td>Margin from the image to the bottom boundary in pixels</td>
          <td>image.DistanceFromBottom = 15;</td>
      </tr>
      <tr>
          <td>Position</td>
          <td>Specifies the X and Y coordinates for placement</td>
          <td>image.Position = new ElementPosition(50, 100);</td>
      </tr>
      <tr>
          <td>Scale</td>
          <td>Adjust the scaling factors along X and Y axes</td>
          <td>image.Scale = new PointF(1.5f, 1.5f);</td>
      </tr>
      <tr>
          <td>Translate</td>
          <td>Move the image by certain coordinates</td>
          <td>image.Translate = new PointF(20, 30);</td>
      </tr>
    </tbody>
  </table>
</div>

### Setting Custom Width & Height

Here’s how you can customize the dimensions and aspect ratio of an image:

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Initialize the DOCX document
WordDocument doc = new IronWord.WordDocument();

// Instantiate the image object
IronWord.Models.ImageContent image = new IronWord.Models.ImageContent("sample-image.tiff");

// Modify dimensions to custom values
image.Width = 800;
image.Height = 200;

// Add the modified image to the document
doc.AddImage(image);

// Save and export the adjusted document
doc.SaveAs("custom-size-image.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-image/add-image-custom-size.webp" alt="Add Image Custom Size" class="img-responsive add-shadow">
    </div>
</div>