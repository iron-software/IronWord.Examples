using IronWord;
using IronWord.Models;

// Create table
Table table = new Table(5, 3);

// Apply styling
table.Zebra = new ZebraColor("FFFFFF", "dddddd");

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

// Create new Word document from the table
WordDocument doc = new WordDocument(table);

// Export Word document
doc.SaveAs("Document.docx");
