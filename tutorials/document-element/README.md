# Document Element Tutorial

> Full guide: [Document Element Tutorial](https://ironsoftware.com/csharp/word/tutorials/document-element/)


IronWord is a library designed for .NET C# developers. It facilitates the integration of Word document operations—such as creation, reading, and editing—directly into their software applications. Within a Word document, document elements serve as the foundational components that compile the document's content.

## Quickstart: Combine Styled Text and an Image

Using IronWord, you can swiftly incorporate rich content. This allows you to merge styled text with an embedded image within a single paragraph, all while saving the document through an efficient, fluent code block. This is ideal for developers eager to begin without unnecessary steps.

```cs
new WordDocument()
  .AddParagraph(new Paragraph(new TextContent("Welcome to IronWord!")).AddImage(new ImageContent("https://ironsoftware.com/pic.png")))
  .SaveAs("example.docx");
```

----

## Table of Contents

- **Text Handling**
  - [Text Operations](#text-operations) (Addition, Appending & Segmentation)
  - [Apply Styling](#apply-styling) (Typeface & Size, Color, Bold & Italic, Line-through, Underline, Superscript & Subscript)
  - [Image Embedding](#image-embedding)
- **Image Processing**
  - [Image Retrieval](#load-image) (File & FileStream)
  - [Adjust Text Wrapping](#configure-image)
  - [Modify Dimensions](#configure-image) (Width & Height)
  - [Alter Position](#configure-image)
  - [Set Margin](#configure-image)

## Text Blocks

### Text Operations

The `Split` method allows the separation of a text run into multiple smaller TextRuns based on a chosen delimiter, facilitating structured document authoring.

```csharp
using IronWord;
using IronWord.Models;

WordDocument doc = new WordDocument();

// Add text
TextContent newText = new TextContent("Add text using IronWord");
doc.AddParagraph(new Paragraph(newText));

// Extend text
TextContent extraText = new TextContent("Initial text.");
extraText.Append(new TextContent("Additional text."));
doc.AddParagraph(new Paragraph(extraText));

// Divide text
TextContent textToSplit = new TextContent("Divide this sentence into segments.");
textToSplit.Split(" ");
doc.AddParagraph(new Paragraph(textToSplit));

// Save the document
doc.SaveAs("text-example.docx");
```

### Apply Styling

Adjusting styling for TextRuns involves setting the visual characteristics of the text. This might include font characteristics, color, styling, and other textual attributes to enhance document readability.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Open an existing document
WordDocument doc = new WordDocument("document.docx");

// Set up text
TextContent styledText = new TextContent("Styling with IronWord");
styledText.Style = new TextStyle()
{
    TextFont = new Font()
    {
        FontFamily = "Caveat",
        FontSize = 72,
    },
    Color = Color.Blue,
    IsBold = true,
    IsItalic = false,
    Underline = new Underline(),
    Strike = StrikeValue.NoStrike,
};

Paragraph styledParagraph = new Paragraph();

// Add styled text
styledParagraph.AddText(styledText);

// Insert styled paragraph
doc.AddParagraph(styledParagraph);

// Save the styled document
doc.SaveAs("styled-doc.docx");
```

### Obtain Text Fill Color

IronWord provides methods to retrieve the RGBA color of the text, allowing for consistent styling across the document.

```cs
using IronWord;
using IronWord.Models;
using System;

// Open a Word document
WordDocument doc = new WordDocument("Accent1TextThemeColor.docx");

TextContent content = doc.Paragraphs[0].Texts[0];

// Retrieve RGBA values
var fillColor = content.FillColor;

// Display RGBA values
Console.WriteLine(fillColor);
```

IronWord initializes the `WordDocument` instance, accesses the first paragraph, retrieves the text, and fetches the `FillColor`, displaying RGBA values of the theme color.

### Image Embedding

Embedding images enhances documents by adding visual elements that communicate more than text alone.

```csharp
using IronWord;
using IronWord.Models;

// Start with a fresh document
WordDocument doc = new WordDocument();

// Prepare image settings
ImageContent imageSetup = new ImageContent("https://ironsoftware.com/image.jpg");
imageSetup.Width = 200; // in pixels
imageSetup.Height = 200; // in pixels
TextContent accompanyingText = new TextContent();

// Combine text and image
Paragraph combinePara = new Paragraph(accompanyingText);
combinePara.AddImage(imageSetup);

// Embed into document
doc.AddParagraph(new Paragraph(accompanyingText));

// Finalize the document
doc.SaveAs("document-with-image.docx");
```

## Image Processing

### Load Image

Extracting and embedding images into the document is an essential feature in enhancing the document with relevant visual content.

```csharp
using IronWord;
using IronWord.Models;

// Begin a new document
WordDocument doc = new WordDocument();

Paragraph para = new Paragraph();

// Embed an image
para.AddImage("https://ironsoftware.com/image.jpg");

// Append the paragraph
doc.AddParagraph(para);

// Finalize and save
doc.SaveAs("image-doc.docx");
```

### Configure Image

Configuring image settings allows for tailored placement and appearance, ensuring images complement the textual content.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Create a new document
WordDocument doc = new WordDocument();

// Image configuration
ImageContent imageSettings = new ImageContent("https://ironsoftware.com/image.jpg");
imageSettings.WrapText = WrapText.Square;
imageSettings.Width = 100;
imageSettings.Height = 100;
imageSettings.DistanceFromTop = 50;

var placement = new ElementPosition();
placement.X = 50;
placement.Y = 50;
imageSettings.Position = placement;

Paragraph imageParagraph = new Paragraph();

// Embed configured image
imageParagraph.AddImage(imageSettings);

// Add paragraph
doc.AddParagraph(imageParagraph);

// Export the configured document
doc.SaveAs("configured-image.docx");
```