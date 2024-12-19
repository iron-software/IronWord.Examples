using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.HowTo.AddTable
{
    public static class Section1
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
            table[0, 0] = new TableCell(new Text("Number"));
            table[0, 1] = new TableCell(new Text("First Name"));
            table[0, 2] = new TableCell(new Text("Last Name"));
            for (int i = 1; i < table.Rows.Count; i++)
            {
                table[i, 0].AddChild(new Text($"{i}"));
                table[i, 1].AddChild(new Text($"---"));
                table[i, 2].AddChild(new Text($"---"));
            }
            
            // Add table
            doc.AddTable(table);
            
            doc.Save("document.docx");
        }
    }
}