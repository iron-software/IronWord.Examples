# How to Insert a Table into a DOCX Document

***Based on <https://ironsoftware.com/how-to/add-table/>***


Tables, made up of rows and columns, are essential tools for structuring and displaying data clearly and efficiently in a document. Each cell, found at the intersection of a row and a column, can hold a variety of data types including text and numbers. This makes tables an ideal choice for data organization, schedules, and formatted information display.

### Getting Started with IronWord

---

## Example: Adding a Table

Incorporating a table into a Word document involves several steps. First, create an instance of the `Table` class with the desired number of rows and columns. Next, customize the table using options like background color, shading, borders, zebra striping, and column widths. You can also directly manipulate the contents of each cell by referencing its position in the table using `[row, column]` notation. Each cell can hold different content types like text, images, or other tables. Once set up, this table is ready to be integrated into your document.

All row and column index positions are zero-based, meaning counting starts from zero.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

WordDocument doc = new WordDocument();

// Initialize a table with specified rows and columns
Table table = new Table(5, 3);

// Define border style
BorderStyle borderStyle = new BorderStyle {
    BorderColor = Color.Black,
    BorderValue = BorderValues.Thick,
    BorderSize = 5
};

// Configure the table's borders
TableBorders tableBorders = new TableBorders {
    TopBorder = borderStyle,
    RightBorder = borderStyle,
    BottomBorder = borderStyle,
    LeftBorder = borderStyle
};

// Set zebra striping and borders
table.Zebra = new ZebraColor("FFFFFF", "dddddd");
table.Borders = tableBorders;

// Fill the table with data
table[0, 0] = new TableCell(new Text("Number"));
table[0, 1] = new TableCell(new Text("First Name"));
table[0, 2] = new TableCell(new Text("Last Name"));
for (int i = 1; i < table.Rows.Count; i++) {
    table[i, 0].AddChild(new Text($"{i}"));
    table[i, 1].AddChild(new Text($"---"));
    table[i, 2].AddChild(new Text($"---"));
}

// Append the table to the document
doc.AddTable(table);

doc.Save("document.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/add-table.webp" alt="Add table" class="img-responsive add-shadow">
    </div>
</div>

The `AddContent` method of the `TableCell` class allows adding various types of content, from paragraphs to nested tables, which enhances the document’s functionality and presentation.

## Stylings Available

### Borders

View all the border styles offered by the `BorderValues` enum:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/border-value.webp" alt="Border values" class="img-responsive add-shadow">
    </div>
</div>