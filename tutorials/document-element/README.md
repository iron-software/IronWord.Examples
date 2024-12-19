# Document Element Tutorial

***Based on <https://ironsoftware.com/tutorials/document-element/>***


IronWord is a sophisticated library that enables .NET C# developers to seamlessly integrate Word and DOCX document processing capabilities—such as creation, reading, and modification—into their applications. In a Word document, these "document elements" act as fundamental components that compose the document's structure.

## Table of Contents

- **Add TextRuns**
  - [Text Content](#anchor-text-content) (Add, Append & Split)
  - [Set Styling](#anchor-set-styling) (Font Family & Size, Color, Bold & Italic, Strikethrough, Underline, Superscript & Subscript)
  - [Embed Images](#anchor-embed-images)
- **Add Images**
  - [Load Image](#anchor-load-image) (File & FileStream)
  - [Set Wrap Text](#anchor-configure-image)
  - [Set Dimensions](#anchor-configure-image) (Width & Height)
  - [Set Position Offset](#anchor-configure-image)
  - [Set Distance from Corners](#anchor-configure-image)

<h3>Get started with IronZIP</h3>

------------------

## Add TextRuns

### Text Content

Utilizing the `Split` function, you can break a text run into multiple smaller TextRuns using a designated delimiter. This feature is advantageous for organizing and managing text effectively within your document.

```cs
using IronWord;
using IronWord.Models;

WordDocument doc = new WordDocument();

// Adding text
Text addText = new Text("Incorporate text with IronWord");
doc.AddParagraph(new Paragraph(addText));

// Appending text
Text appendText = new Text("Initial text.");
appendText.Append(new Text("Additional text."));
doc.AddParagraph(new Paragraph(appendText));

// Splitting text
Text splitText = new Text("Demonstrate splitting of this sentence.");
splitText.Split(" ");
doc.AddParagraph(new Paragraph(splitText));

// Save the document
doc.SaveAs("example_text.docx");
```

### Set Styling

You can establish the text's visual aspects through styling options in TextRuns, such as font type, size, color, and text formatting like bold, italic, strikethrough, and underlining, including superscript and subscript. Styling elevates the document’s visual appeal and readability.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Open existing docx file
WordDocument doc = new WordDocument("styled_document.docx");

// Set text properties
Text textRun = new Text();
textRun.Text = "Enhance text with IronWord";
textRun.Style = new TextStyle()
{
    TextFont = new Font()
    {
        FontFamily = "Arial",
        FontSize = 48,
    },
    Color = Color.Blue,
    IsBold = true,
    IsItalic = false,
    Underline = new Underline(),
    Strike = StrikeValue.None,
};

Paragraph paragraph = new Paragraph();

// Add the styled text to the paragraph
paragraph.AddText(textRun);

// Add styled paragraph
doc.AddParagraph(paragraph);

// Save the styled document
doc.SaveAs("styled_output.docx");
```

### Embed Images

Embedding images into your document amplifies the visual appeal and communicative effectiveness, making the content more engaging and illustrative.

```cs
using IronWord;
using IronWord.Models;

// Create a new Word document
WordDocument doc = new WordDocument();

// Prepare the image and its settings
IronWord.Models.Image image = new IronWord.Models.Image("https://ironsoftware.com/csharp/ocr/assetcs/image.jpg");
image.Width = 300; // Specify width in pixels
image.Height = 300; // Specify height in pixels
Text textRun = new Text();

// Embed the image in a new paragraph
Paragraph para = new Paragraph(textRun);
para.AddImage(image);

// Append the new paragraph with the image
doc.AddParagraph(new Paragraph(textRun));

// Save the document with the image
doc.SaveAs("document_with_images.docx");
```

## Add Images

### Load Image

The process of loading images involves importing external visual files into the document. Being able to incorporate these visuals helps in making the document more engaging and enriching the content visually.

```cs
using IronWord;
using IronWord.Models;

// Initiate a new Word document
WordDocument doc = new WordDocument();

Paragraph paragraph = new Paragraph();

// Insert an external image
paragraph.AddImage("https://ironsoftware.com/csharp/ocr/assets/image.jpg");

// Append the paragraph to the document
doc.AddParagraph(paragraph);

// Export the document containing the image
doc.SaveAs("image_included.docx");
```

### Configure Image

Enhance your document's layout by configuring images with properties such as text wrapping, size, positioning, and alignment relative to page elements. These adjustments help with the aesthetic integration of images within the document.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Start a new Word document
WordDocument doc = new WordDocument();

// Image settings
IronWord.Models.Image image = new IronWord.Models.Image("https://ironsoftware.com/csharp/ocr/assets/image.jpg");
image.WrapText = WrapText.Tight;
image.Width = 150;
image.Height = 150;
image.DistanceFromTop = 30;

var position = new ElementPosition();
position.X = 100;
position.Y = 100;
image.Position = position;

Paragraph paragraph = new Paragraph();

// Embed the configured image
paragraph.AddImage(image);

// Include the paragraph
doc.AddParagraph(paragraph);

// Save the configured document
doc.SaveAs("configured_image.docx");
```