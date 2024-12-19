using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Overview.Quickstart
{
    public static class Section4
    {
        public static void Run()
        {
            // Create table cell
            TableCell cell = new TableCell();
            
            Text textRun = new Text();
            textRun.Text = "Sample text";
            
            // Add textrun to the cell
            cell.AddChild(new Paragraph(textRun));
            
            // Configure border style
            BorderStyle borderStyle = new BorderStyle();
            borderStyle.BorderColor = Color.Black;
            borderStyle.BorderValue = IronWord.Models.Enums.BorderValues.Thick;
            borderStyle.BorderSize = 5;
            
            // Configure table border
            TableBorders tableBorders = new TableBorders() {
                TopBorder = borderStyle,
                RightBorder = borderStyle,
                BottomBorder = borderStyle,
                LeftBorder = borderStyle,
            };
            
            cell.Borders = tableBorders;
            
            // Create row and add cell
            TableRow row = new TableRow();
            row.AddCell(cell);
            row.AddCell(cell);
            
            // Create table and add row
            Table table = new Table();
            table.AddRow(row);
            
            // Create new Word document from the table
            WordDocument doc = new WordDocument(table);
            
            // Export Word document
            doc.SaveAs("Document.docx");
        }
    }
}