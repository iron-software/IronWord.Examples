# Getting Started with IronWord

***Based on <https://ironsoftware.com/docs/docs/>***


## IronWord: Word Document Library for .NET

**IronWord** is a Word document library crafted by Iron Software. It specializes in offering robust tools for manipulating Word documents within .NET applications.

- Load, edit, and save Word and Docx files.
- `PageSetup`: Adjust paper size, orientation, margins, and background color.
- `TextRun`: Manage text blocks, style properties, text manipulations, and image insertions.
- `TextStyle`: Control font style, size, color, weight, emphasis, and script adjustments.
- `Paragraph`: Insert text blocks, images, and shapes, and configure style, alignment, and list formatting.
- `Table`: Manage and modify table layouts, add rows, handle cell content, delete rows, and merge cells.
- `Image`: Embed images from various sources, adjust text wrapping, placement, and dimensions.
- `Shape`: Configure text wrapping, positioning, dimensions, shape styles, and rotation angles.

## Installation

### IronWord Library

The installation of IronWord is straightforward. Utilize the NuGet package manager with the following command to install the library:

```shell
Install-Package IronWord
```

Alternatively, download directly from the [official IronWord NuGet website](https://www.nuget.org/packages/IronWord).

Start by including `using IronWord;` at the beginning of your C# file to use the library.

## Applying License Key

To activate IronWord, set a valid license or trial key by assigning it to the `LicenseKey` property within the `License` class. Place the following code immediately after your namespace declaration, prior to utilizing any IronWord functionality:

```csharp
using IronWord;

// Apply your license key
License.LicenseKey = "YOUR_LICENSE_KEY_HERE";
```

## Code Examples

The following sections will guide you through various features of IronWord.

When you open a DOCX file created with IronWord in Microsoft Word, it might display in **Compatibility Mode**, which can restrict some styling features. To switch out of this mode:

1. Go to 'File' > 'Info' and select "Convert."
2. A message will inform you that your document will be updated to the latest file format. Confirm by clicking "OK."

## Create Word and Docx Document

To begin, create a new Word document by initializing a `WordDocument` object. To export your document, utilize the `SaveAs` method. For example:

```csharp
using IronWord;

class Program
{
    static void Main()
    {
        // Start a new Word document
        var document = new WordDocument();

        // Output the document as a .docx file
        document.SaveAs("example.docx");
    }
}
```

## Add Image

To incorporate an image, it must be included within document structures like a `Paragraph`, `TableCell`, or `Section`. Employ the `AddImage` method for this purpose. For instance:

```csharp
using IronWord;
using System.Drawing;

class Program
{
    static void Main()
    {
        var document = new WordDocument();
        var section = document.Sections.Add();

        // Embed an image within a paragraph
        var paragraph = section.Paragraphs.Add();
        paragraph.AddImage("path/to/image.jpg", new Rectangle(0, 0, 100, 100));

        document.SaveAs("example_with_image.docx");
    }
}
```

## Add Table

To add a table, configure the construct of the table, its rows, columns, and cells, which allows for extensive customization. Demonstrated here:

```csharp
using IronWord;

class Program
{
    static void Main()
    {
        var document = new WordDocument();
        var section = document.Sections.Add();
        var table = section.Tables.Add(3, 3); // Construct a 3x3 table

        // Populate each cell with content
        for (int i = 0; i < table.Rows.Count; i++)
        {
            for (int j = 0; j < table.Rows[i].Cells.Count; j++)
            {
                table.Rows[i].Cells[j].Paragraphs.Add().AppendText($"Cell {i+1},{j+1}");
            }
        }

        document.SaveAs("example_with_table.docx");
    }
}
```

## Licensing & Support Available

**IronWord** offers both commercial licenses and trial versions which can be accessed [here](https://ironsoftware.com/csharp/word/docs/trial-license).

For additional information about Iron Software, visit our website at: <https://ironsoftware.com/>. For further assistance and queries, you can [contact our team](https://www.ironsoftware.com/csharp/word/docs/#live-chat-support).

### Support from Iron Software

For general support and technical questions, reach out to us via email at: <support@ironsoftware.com>