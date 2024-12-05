using IronWord;
using IronWord.Models;

// Load docx
WordDocument doc = new WordDocument("document.docx");

// Add text
doc.AddText("Add text using IronWord");

// Export docx
doc.SaveAs("save_document.docx");
