using IronWord;
using IronWord.Models;

// Create textrun
TextContent textRun = new TextContent("Sample text");

Paragraph paragraph = new Paragraph();
paragraph.AddChild(textRun);

// Create a new Word document
WordDocument doc = new WordDocument(paragraph);

// Export docx
doc.SaveAs("document.docx");
