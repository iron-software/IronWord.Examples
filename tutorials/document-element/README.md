# Word Document Element Guide

***Based on <https://ironsoftware.com/tutorials/document-element/>***


IronWord is an exceptional library tailored for .NET C# developers, facilitating the integration of Word and DOCX document manipulation capabilities into their applications. Document elements serve as the core components in constructing the content of a Word document.

## Table of Contents

- **Manipulating TextRun Elements**
  - [Working with Text Content](#anchor-text-content) (Adding, Appending & Splitting)
  - [Applying Styling Options](#anchor-set-styling) (Changing Font, Size, Color, Bold, Italic, Strikethrough, Underline, Superscript & Subscript)
  - [Inserting Images](#anchor-embed-images)
- **Incorporating Images**
  - [Loading Images](#anchor-load-image) (From File & FileStream)
  - [Adjusting Text Wrapping](#anchor-configure-image)
  - [Modifying Dimensions](#anchor-configure-image) (Specify Width & Height)
  - [Altering Positioning](#anchor-configure-image)
  - [Setting Margins](#anchor-configure-image)

## Manipulating TextRun Elements

### Working with Text Content

To facilitate the organization and management of text, the `Split` method splits a TextRun into multiple smaller TextRuns using a specific delimiter.

```cs
using IronWord.Models;
using IronWord;

namespace ironword.DocumentElement
{
    public class Section1
    {
        public void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Create text
            Text newText = new Text("Create using IronWord");
            doc.AddParagraph(new Paragraph(newText));
            
            // Append additional text
            Text additionalText = new Text("Initial text.");
            additionalText.Append(new Text("Further appended text."));
            doc.AddParagraph(new Paragraph(additionalText));
            
            // Splitting text
            Text textForSplitting = new Text("Demonstrate text splitting with IronWord.");
            textForSplitting.Split(" ");
            doc.AddParagraph(new Paragraph(textForSplitting));
            
            // Save document
            doc.SaveAs("textManipulation.docx");
        }
    }
}
```

### Applying Styling Options

Text styling options in TextRuns allow for the adjustment of visual aspects like font size, color, and formatting to elevate the document's aesthetic appeal.

```cs
using IronWord.Models.Enums;
using IronWord;

namespace ironword.DocumentElement
{
    public class Section2
    {
        public void Run()
        {
            // Open document
            WordDocument doc = new WordDocument("styledDocument.docx");
            
            // Styling the text
            Text styledText = new Text();
            styledText.Text = "Styling text with IronWord";
            styledText.Style = new TextStyle()
            {
                TextFont = new Font()
                {
                    FontFamily = "Montserrat",
                    FontSize = 48,
                },
                Color = Color.Blue,
                IsBold = true,
                IsItalic = false,
                Underline = new Underline(),
                Strike = StrikeValue.NoStrike,
            };
            
            Paragraph paragraph = new Paragraph();
            
            // Adding styled text
            paragraph.AddText(styledText);
            
            // Including the paragraph
            doc.AddParagraph(paragraph);
            
            // Save the styled document
            doc.SaveAs("styledOutput.docx");
        }
    }
}
```

### Inserting Images

Incorporate images into documents to enhance visual interactivity and convey information more effectively.

```cs
using IronWord.Models;
using IronWord;

namespace ironword.DocumentElement
{
    public class Section3
    {
        public void Run()
        {
            // Initialize document
            WordDocument doc = new WordDocument();
            
            // Setup image
            IronWord.Models.Image detailedImage = new IronWord.Models.Image("image.jpg");
            detailedImage.Width = 250; // Pixel units
            detailedImage.Height = 250; // Pixel units
            Text imageCaption = new Text();
            
            // Embed image
            Paragraph imageParagraph = new Paragraph(imageCaption);
            imageParagraph.AddImage(detailedImage);
            
            // Append image with caption
            doc.AddParagraph(new Paragraph(imageCaption));
            
            // Finalize document
            doc.SaveAs("documentWithImages.docx");
        }
    }
}
```

## Incorporating Images

### Loading Images

The process of loading images involves importing them into the document, which is essential for enriching the content with relevant visuals.

```cs
using IronWord.Models;
using IronWord;

namespace ironword.DocumentElement
{
    public class Section4
    {
        public void Run()
        {
            // Open new document
            WordDocument doc = new WordDocument();
            
            Paragraph imgParagraph = new Paragraph();
            
            // Include image
            imgParagraph.AddImage("image.jpg");
            
            // Insert into document
            doc.AddParagraph(imgParagraph);
            
            // Save the document with image
            doc.SaveAs("imageLoadedDocument.docx");
        }
    }
}
```

### Configuring Image Properties

Adjust image settings such as wrap style, dimensions, positioning, and margins to ensure they fit within the document context suitably.

```cs
using IronWord.Models.Enums;
using IronWord;

namespace ironword.DocumentElement
{
    public class Section5
    {
        public void Run()
        {
            // Initialize new document
            WordDocument doc = new WordDocument();
            
            // Set up the image
            IronWord.Models.Image configuredImage = new IronWord.Models.Image("image.jpg");
            configuredImage.WrapText = WrapText.Tight;
            configuredImage.Width = 150;
            configuredImage.Height = 150;
            configuredImage.DistanceFromTop = 30;
            
            var imagePosition = new ElementPosition();
            imagePosition.X = 30;
            imagePosition.Y = 30;
            configuredImage.Position = imagePosition;
            
            Paragraph imgParagraph = new Paragraph();
            
            // Embed configured image
            imgParagraph.AddImage(configuredImage);
            
            // Add the configured paragraph
            doc.AddParagraph(imgParagraph);
            
            // Document saving
            doc.SaveAs("configuredImagedDocument.docx");
        }
    }
}
```