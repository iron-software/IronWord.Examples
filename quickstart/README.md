# Getting Started with IronWord

***Based on <https://ironsoftware.com/docs/docs/>***


## IronWord: Word Document Library for .NET

**IronWord** by Iron Software is a comprehensive library designed to handle Word documents in .NET applications.

- **Load, Manipulate, and Save**: Easily manage Word and `.docx` documents.
- **PageSetup**: Set paper size, page orientation, and margins, and modify background colors.
- **TextRun**: Manage text including styling, adding, or splitting content, and embedding images.
- **TextStyle**: Control text appearance including font settings, color, decoration, and sizing.
- **Paragraph**: Incorporate elements like text, images, and shapes, define styles, and apply bullet or numbered lists.
- **Table**: Adjust table layouts by modifying rows, cells, and structures, and utilize merging and styling capabilities.
- **Image**: Embed images with customizable settings for size, wrapping, and positioning.
- **Shape**: Define shape dimensions, types, rotations, and text wrapping.

## Installation

### IronWord Library

For a swift installation of IronWord, use this command:

```shell
Install-Package IronWord
```

You can also download it directly from the [official IronWord NuGet page](https://www.nuget.org/packages/IronWord).

Post-installation, initiate your project by including `using IronWord;` at the beginning of your C# files.

## Applying License Key

To activate IronWord, insert your license or trial key into the `LicenseKey` property of the `License` class immediately after referencing IronWord in your code:

```csharp
using IronWord;
namespace ironword.Quickstart
{
    public class Section1
    {
        public void Run()
        {
            IronWord.License.LicenseKey = "IRONWORD.MYLICENSE.KEY.1EF01";
        }
    }
}
```

## Code Examples

When opening a DOCX file in Microsoft Word, ensure it's in the modern format and not Compatibility Mode by navigating to 'File' > 'Info' and selecting "Convert," followed by "OK" to update the file format.

## Create Word and Docx Document

Begin with constructing a new Word document by initializing the `WordDocument` class and then exporting it using `SaveAs`.

```csharp
using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section2
    {
        public void Run()
        {
            // Initialize new text element
            Text textRun = new Text("Sample text");
            
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(textRun);
            
            // Instantiate a Word document
            WordDocument doc = new WordDocument(paragraph);
            
            // Save the document
            doc.SaveAs("document.docx");
        }
    }
}
```

## Add Image

Integrate images into your document elements like `Paragraph`, `TableCell`, or `Section` with `AddImage`.

```csharp
using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section3
    {
        public void Run()
        {
            // Open an existing document
            WordDocument doc = new WordDocument("document.docx");
            
            // Configure a new image
            IronWord.Models.Image image = new IronWord.Models.Image("image.jpg");
            image.Width = 250;
            image.Height = 200;
            Paragraph paragraph = new Paragraph();
            
            // Insert the image into the paragraph
            paragraph.AddImage(image);
            
            // Append paragraph to the document
            doc.AddParagraph(paragraph);
            
            // Output the document
            doc.SaveAs("save_document.docx");
        }
    }
}
```

## Add Table

Design detailed tables with customizable cells and styles.

```csharp
using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section4
    {
        public void Run()
        {
            TableCell cell = new TableCell();

            Text textRun = new Text("Sample text");

            cell.AddChild(new Paragraph(textRun));

            BorderStyle borderStyle = new BorderStyle() {
                BorderColor = Color.Black,
                BorderValue = IronWord.Models.Enums.BorderValues.Thick,
                BorderSize = 5
            };

            TableBorders tableBorders = new TableBorders() {
                TopBorder = borderStyle,
                RightBorder = borderStyle,
                BottomBorder = borderStyle,
                LeftBorder = borderStyle
            };

            cell.Borders = tableBorders;

            TableRow row = new TableRow();
            row.AddCell(cell);
            row.AddCell(cell);

            Table table = new Table();
            table.AddRow(row);

            WordDocument doc = new WordDocument(table);

            doc.SaveAs("Document.docx");
        }
    }
}
```

## Licensing & Support Available

**IronWord** offers both paid licenses and free trial options available on [this page](https://ironsoftware.com/csharp/ocr/trial-license).

For more details about Iron Software, please visit our [website](https://ironsoftware.com/). For additional support, you can [reach out to our team](https://ironsoftware.com/csharp/ocr/#live-chat-support).

### Support from Iron Software

For general inquiries and technical assistance, reach out to us via email: <support@ironsoftware.com>