# How to Incorporate a Table into a DOCX Document

***Based on <https://ironsoftware.com/how-to/add-table/>***


A table, essentially a matrix layout consisting of rows and columns, is a core component in organizing and displaying data in a document. Each row-column intersection forms a cell that can host various types of content like text or numbers, and is advantageous for structuring data efficiently, arranging schedules, or presenting information in an easily understandable way.

## Inserting a Table into Your Document

Incorporating a table into a Word document involves several straightforward steps. Initially, create an instance of the **Table** class by specifying the desired number of rows and columns. This setup allows for the customization of various styling elements such as the table's background color, shading, borders, zebra striping, and overall width. Additionally, you can populate each cell of the table by referring to its row and column indices, denoted as **[row, column]**. Cells are versatile, capable of containing texts, images, shapes—or even other tables. Once configured, the table can be seamlessly integrated into the document.

The indices for rows and columns start from zero, known as zero-based indexing.

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
            
            // Initializing a new table instance
            Table table = new Table(5, 3);
            
            // Setting up table border styles
            BorderStyle borderStyle = new BorderStyle()
            {
                BorderColor = Color.Black,
                BorderValue = BorderValues.Thick,
                BorderSize = 5
            };
            
            // Applying border styles to table
            TableBorders tableBorders = new TableBorders()
            {
                TopBorder = borderStyle,
                RightBorder = borderStyle,
                BottomBorder = borderStyle,
                LeftBorder = borderStyle
            };
            
            // Applying zebra striping for visual distinction
            table.Zebra = new ZebraColor("FFFFFF", "dddddd");
            table.Borders = tableBorders;
            
            // Filling table headers
            table[0, 0] = new TableCell(new Text("Number"));
            table[0, 1] = new TableCell(new Text("First Name"));
            table[0, 2] = new TableCell(new Text("Last Name"));
            
            // Adding sample data into the table
            for (int i = 1; i < table.Rows.Count; i++)
            {
                table[i, 0].AddChild(new Text($"{i}"));
                table[i, 1].AddChild(new Text("-"));
                table[i, 2].AddChild(new Text("-"));
            }
            
            // Finalizing the table in the document
            doc.AddTable(table);
            
            // Saving the document with the table
            doc.Save("UpdatedDocument.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/add-table.webp" alt="Example of added table" class="img-responsive add-shadow">
    </div>
</div>

In terms of content management within the cells, the `AddContent` function of the TableCell class can accept any ContentElement object. This flexibility is particularly useful for embedding nested tables, which can dramatically enhance the data presentation in certain scenarios.

## Styling Options

### Border Styling

The following visual demonstrates various border styles available through the BorderValues enumeration:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-table/border-value.webp" alt="Table border options" class="img-responsive add-shadow">
    </div>
</div>

In this comprehensive guide, we've demonstrated how to create, style, and implement tables into DOCX documents, enhancing both functionality and aesthetic appeal of your word-processing projects.