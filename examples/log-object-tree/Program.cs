using IronWord;
using IronWord.Models;

WordDocument docx = new WordDocument("Table.docx");

// Log object tree of the whole document
docx.LogObjectTree();

// Log object tree of table 0
docx.Tables[0].LogObjectTree();
