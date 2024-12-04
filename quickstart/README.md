# Getting Started with IronWord

***Based on <https://ironsoftware.com/docs/docs/>***


## IronWord: Word Document Library for .NET

**IronWord** is a specialized library from Iron Software designed to handle Word documents within .NET applications. It offers comprehensive capabilities such as:

- Loading, editing, and saving Word and Docx documents.
- PageSetup: Adjusting paper size, orientation, margins, and background settings.
- TextRun: Managing text including styles, appending sections, and inserting images.
- TextStyle: Controls over text appearance including font type, size, color, and decorations like bold, italic, and underline.
- Paragraph: Inserting text elements, images, or shapes, and setting styles and lists.
- Table: Creating and modifying table layouts, row insertion/removal, and cell merging.
- Image: Embedding images with controls over wrapping, positioning, and sizing.
- Shape: Incorporating graphic shapes with adjustable text wrapping, positioning, size, and rotation.

## Installation

### IronWord Library

Installing IronWord is straightforward. To install, use the following command:

```shell
Install-Package IronWord
```

Or, download it directly from the [IronWord NuGet page](https://www.nuget.org/packages/IronWord).

Begin by importing the library with `using IronWord;` in your C# application.

## Applying License Key

Activate IronWord by setting your license key right after the import statement with this code:

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

When working with DOCX files created by IronWord, you may need to upgrade the file format in Microsoft Word if it opens in **Compatibility Mode**. To do so:

1. Navigate to 'File' > 'Info' and select "Convert."
2. Confirm your action at the prompt to update the document to the new file format.

## Create Word and Docx Document

To generate a new Word document, initiate a `WordDocument` class and use the `SaveAs` method to save the document:

```csharp
using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section2
    {
        public void Run()
        {
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(new Text("Sample text"));
            
            WordDocument doc = new WordDocument(paragraph);
            
            doc.SaveAs("document.docx");
        }
    }
}
```

## Add Image

Images can be incorporated within document structures like paragraphs or table cells. Here’s how to add an image:

```csharp
using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section3
    {
        public void Run()
        {
            WordDocument doc = new WordDocument("document.docx");

            IronWord.Models.Image image = new IronWord.Models.Image("image.jpg");
            image.SetDimensions(250, 200);

            Paragraph paragraph = new Paragraph();
            paragraph.AddImage(image);
            
            doc.AddParagraph(paragraph);
            doc.SaveAs("save_document.docx");
        }
    }
}
```

## Add Table

Constructing a table offers flexibility in design and formatting, especially with border styles:

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
            cell.AddChild(new Paragraph(new Text("Sample text")));

            BorderStyle borderStyle = new BorderStyle();
            borderStyle.ConfigureBorder(Color.Black, IronWord.Models.Enums.BorderValues.Thick, 5);
            
            TableBorders tableBorders = new TableBorders(borderStyle, borderStyle, borderStyle, borderStyle);
            cell.SetBorders(tableBorders);
            
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

## Licensing & Support Options

**IronWord** is a premium library with free trial licenses available [here](https://ironsoftware.com/trial-license).

To learn more about Iron Software or for additional support, visit our official site: [Iron Software](https://ironsoftware.com/) or our [support team](https://ironsoftware.com/#live-chat-support).

### Support from Iron Software

For any general assistance or technical queries, kindly contact us at: <support@ironsoftware.com>