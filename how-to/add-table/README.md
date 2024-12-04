# How to Insert a Table into a DOCX File

***Based on <https://ironsoftware.com/how-to/add-table/>***


A table, consisting of rows and columns, is a fundamental tool for arranging data systematically in a grid format where each cell can hold content such as text, numbers, or images. This structured arrangement is crucial for creating organized presentations of information, scheduling events, or displaying data clearly.

## Table Insertion Guide

Tables play a pivotal role in structuring information within a Word document. Begin by creating an instance of the **Table** class with specified rows and columns. Next, personalize the table by setting styles like background color, shading, border styles, zebra striping, and overall width. Accessing a particular cell is straightforward using the **[row, column]** notation, where you can insert content ranging from text and images to complex elements like paragraphs or even other tables. Once configured, the table can be seamlessly integrated into your document.

Keep in mind that rows and columns are indexed starting from zero.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.AddTable
{
    public class Section1
    {
        public void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Initialize a new table
            Table table = new Table(5, 3);
            
            // Set up the border style
            BorderStyle borderStyle = new BorderStyle()
            {
                BorderColor = Color.Black,
                BorderValue = BorderValues.Thick,
                BorderSize = 5
            };

            // Apply borders to the table
            TableBorders tableBorders = new TableBorders()
            {
                TopBorder = borderStyle,
                RightBorder = borderStyle,
                BottomBorder = borderStyle,
                LeftBorder = borderStyle,
            };

            // Apply zebra striping for readability
            table.Zebra = new ZebraColor("FFFFFF", "dddddd");
            table.Borders = tableBorders;
            
            // Fill in the header row
            table[0, 0] = new TableCell(new Text("Number"));
            table[0, 1] = new TableCell(new Text("First Name"));
            table[0, 2] = new TableCell(new Text("Last Name"));
            
            // Populate the table with sample data
            for (int i = 1; i < table.Rows.Count; i++)
            {
                table[i, 0].AddChild(new Text($"{i}"));
                table[i, 1].AddChild(new Text("Sample Name"));
                table[i, 2].AddChild(new Text("Sample Surname"));
            }
            
            // Insert the table into the document
            doc.AddTable(table);
            
            doc.Save("document.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/add-table.webp" alt="Add table" class="img-responsive add-shadow">
    </div>
</div>

The `AddContent` method in the TableCell class can manage a ContentElement, allowing the inclusion of various content types - from text and graphics to nested tables, which can be especially useful for detailed data representation.

## Styling Options

### Borders

Discover the various styles for table borders available through the BorderValues enumeration:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/border-value.webp" alt="Border values" class="img-responsive add-shadow">
    </div>
</div>