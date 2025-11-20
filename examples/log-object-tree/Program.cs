using IronWord;
using IronWord.Models;
using System.Linq;

WordDocument docx = new WordDocument("Table.docx");

// Log object tree of the whole document
docx.LogObjectTree();

// Log object tree of table 0
docx.Children.OfType<Table>().First().LogObjectTree();
