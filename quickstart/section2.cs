using IronWord;
namespace IronWord.Examples.Overview.Quickstart
{
    public static class Section2
    {
        public static void Run()
        {
            class Program
            {
                static void Main()
                {
                    var document = new WordDocument();
                    var section = document.Sections.Add();
                    var table = section.Tables.Add(3, 3); // 3x3 table
            
                    // Iterate over cells and set their content
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
        }
    }
}