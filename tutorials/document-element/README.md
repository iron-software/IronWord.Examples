# Document Element Guideline

***Based on <https://ironsoftware.com/tutorials/document-element/>***


IronWord offers a robust library ideal for .NET C# developers looking to embed functionality for creating, reading, and editing Word and DOCX documents within their applications. Within a Word document, document elements form the foundational components that comprise the content.

## Table of Contents

- **Manipulate TextRuns**
  - [Text Manipulation](#anchor-text-content) (Create, Extend & Divide)
  - [Apply Styles](#anchor-set-styling) (Font Settings, Colors, Formatting options like Bold & Italic)
  - [Insert Images](#anchor-embed-images)
- **Manage Images**
  - [Import Image](#anchor-load-image) (File & FileStream Access)
  - [Text Wrapping Options](#anchor-configure-image)
  - [Adjust Size](#anchor-configure-image) (Set Width & Height)
  - [Position Adjustment](#anchor-configure-image)
  - [Margin Settings](#anchor-configure-image)

## Manipulate TextRuns

### Text Manipulation

The `Split` method is applied to fragment a text run into several smaller TextRuns, employing a particular delimiter. This facilitates structured and adjustable text management within the document.

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
            
            // Creating text
            Text newText = new Text("Incorporate text with IronWord");
            doc.AddParagraph(new Paragraph(newText));
            
            // Extending text
            Text extendText = new Text("Initial text.");
            extendText.Append(new Text("Additional text."));
            doc.AddParagraph(new Paragraph(extendText));
            
            // Dividing text
            Text divideText = new Text("Dividing this sentence using the split method.");
            divideText.Split(" ");
            doc.AddParagraph(new Paragraph(divideText));
            
            // Save the document
            doc.SaveAs("manipulated-text.docx");
        }
    }
}
```

### Apply Styles

Applying styles to TextRuns allows for the adjustment of visual elements of text such as font properties, color, and styling options like boldness, italics, as well as text formatting features like underline and strikethrough.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.DocumentElement
{
    public class Section2
    {
        public void Run()
        {
            WordDocument doc = new WordDocument("styled-doc.docx");
            
            // Set up text style
            Text styledText = new Text();
            styledText.Text = "Styling with IronWord";
            styledText.Style = new TextStyle()
            {
                TextFont = new Font()
                {
                    FontFamily = "Times New Roman",
                    FontSize = 48,
                },
                Color = Color.Blue,
                IsBold = true,
                IsItalic = false,
                Underline = new Underline(),
                Strike = StrikeValue.None,
            };
            
            Paragraph paragraph = new Paragraph();
            
            // Include styled text
            paragraph.AddText(styledText);
            
            // Append paragraph
            doc.AddParagraph(paragraph);
            
            // Output the document
            doc.SaveAs("styled-output.docx");
        }
    }
}
```

### Insert Images

Facilitate the incorporation of images within your content to enhance visual attractiveness and communication effectiveness of your document.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.DocumentElement
{
    public class Section3
    {
        public void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Prepare image
            IronWord.Models.Image newImage = new IronWord.Models.Image("image.jpg");
            newImage.Width = 300; // Size in pixels
            newImage.Height = 300; // Size in pixels
            Text imageText = new Text();
            
            // Incorporate image
            Paragraph para = new Paragraph(imageText);
            para.AddImage(newImage);
            
            // Include paragraph
            doc.AddParagraph(new Paragraph(imageText));
            
            // Document export
            doc.SaveAs("image-inclusion.docx");
        }
    }
}
```

## Manage Images

### Import Image

Importing images is critical for integrating visual elements into your documents. This functionality enhances the display and enriches the content of your documents.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.DocumentElement
{
    public class Section4
    {
        public void Run()
        {
            WordDocument doc = new WordDocument();
            
            Paragraph paragraph = new Paragraph();
            
            // Include image
            paragraph.AddImage("image.jpg");
            
            // Append paragraph
            doc.AddParagraph(paragraph);
            
            // Document output
            doc.SaveAs("imported-image.docx");
        }
    }
}
```

### Configure Image

Adjust images with configurable settings including text wrapping, dimensions, and positioning, ensuring they fit well within the context of the document.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.DocumentElement
{
    public class Section5
    {
        public void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Set image properties
            IronWord.Models.Image configuredImage = new IronWord.Models.Image("image.jpg");
            configuredImage.WrapText = WrapText.Square;
            configuredImage.Width = 150;
            configuredImage.Height = 150;
            configuredImage.DistanceFromTop = 60;
            
            var position = new ElementPosition();
            position.X = 60;
            position.Y = 60;
            configuredImage.Position = position;
            
            Paragraph paragraph = new Paragraph();
            
            // Add configured image
            paragraph.AddImage(configuredImage);
            
            // Append paragraph
            doc.AddParagraph(paragraph);
            
            // Save the configured document
            doc.SaveAs("configured-image.docx");
        }
    }
}
```