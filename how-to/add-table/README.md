# How to Incorporate Tables into DOCX Documents

***Based on <https://ironsoftware.com/how-to/add-table/>***


A table, essentially a structured grid, comprises rows and columns that intersect to form cells. These cells can house a variety of data such as text and numbers, facilitating organized data presentation, schedule creation, and more.

*as-heading:2(Quickstart: Add a Table Efficiently)*

In this streamlined approach using IronWord, you can quickly generate a table, configure its properties, populate it, embed it in a document, and save the outcome. This enables you to produce a DOCX document with a well-designed table effortlessly.

```cs
:title=Quick Table Creation
var table = new IronWord.Models.Table(3, 4);
var doc = new IronWord.WordDocument();
doc.AddTable(table);
doc.SaveAs("StyledTable.docx");
```

## Detailed Table Addition Example

Adding a table to a Word document is straightforward. Begin by creating a new instance of the `Table` class, specifying its dimensions in terms of rows and columns. This table can then be customized in terms of background colors, borders, and other styling options to enhance its appearance.

It's simple to add content to any cell within the table by indexing it with `[row, column]` notation. Cells can contain a range of elements from text and images to paragraphs and even other tables.

Indexes for rows and columns start from zero.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

WordDocument doc = new WordDocument();

// Initialize a new table
Table table = new Table(5, 3);

// Define border properties
BorderStyle borderStyle = new BorderStyle()
{
    BorderColor = Color.Black,
    BorderValue = BorderValues.Thick,
    BorderSize = 5
};

// Set table borders
TableBorders tableBorders = new TableBorders()
{
    TopBorder = borderStyle,
    RightBorder = borderStyle,
    BottomBorder = borderStyle,
    LeftBorder = borderStyle
};

// Set table styling
table.Zebra = new ZebraColor("FFFFFF", "dddddd");
table.Borders = tableBorders;

// Populate the table
table[0, 0] = new TableCell(new TextContent("Number"));
table[0, 1] = new TableCell(new TextContent("First Name"));
table[0, 2] = new TableCell(new TextContent("Last Name"));
for (int i = 1; i < table.Rows.Count; i++)
{
    table[i, 0].AddChild(new TextContent($"{i}"));
    table[i, 1].AddChild(new TextContent("Placeholder"));
    table[i, 2].AddChild(new TextContent("Placeholder"));
}

// Insert the table into the document
doc.AddTable(table);

doc.Save("completeDocument.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/add-table.webp" alt="Inserting a table" class="img-responsive add-shadow">
    </div>
</div>

The `AddChild` function of the `TableCell` class allows for the insertion of any `ContentElement`, ranging from paragraphs to images and other tables, offering rich capabilities for nested data structures.

## Styling Options

### Borders

Browse all the possibilities for setting table borders using the `BorderValues` enum, which offers a variety of border styles:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/border-value.webp" alt="Table border options" class="img-responsive add-shadow">
    </div>
</div>