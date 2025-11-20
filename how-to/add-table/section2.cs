using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.HowTo.AddTable
{
    public static class Section2
    {
        public static void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Create table
            Table table = new Table(5, 3);
            
            // Configure border style
            BorderStyle borderStyle = new BorderStyle();
            borderStyle.BorderColor = Color.Black;
            borderStyle.BorderValue = BorderValues.Thick;
            borderStyle.BorderSize = 5;
            
            // Configure table border
            TableBorders tableBorders = new TableBorders()
            {
                TopBorder = borderStyle,
                RightBorder = borderStyle,
                BottomBorder = borderStyle,
                LeftBorder = borderStyle,
            };
            
            // Apply styling
            table.Zebra = new ZebraColor("FFFFFF", "dddddd");
            table.Borders = tableBorders;
            
            // Populate table
            table[0, 0] = new TableCell(new TextContent("Number"));
            table[0, 1] = new TableCell(new TextContent("First Name"));
            table[0, 2] = new TableCell(new TextContent("Last Name"));
            for (int i = 1; i < table.Rows.Count; i++)
            {
                table[i, 0].AddChild(new TextContent($"{i}"));
                table[i, 1].AddChild(new TextContent($"---"));
                table[i, 2].AddChild(new TextContent($"---"));
            }
            
            // Add table
            doc.AddTable(table);
            
            doc.Save("document.docx");
        }
    }
}