using IronWord;
using IronWord.Models;

// Create textrun
Text textRun = new Text("Sample text");

Paragraph paragraph = new Paragraph();
paragraph.AddChild(textRun);

// Create a new Word document
WordDocument doc = new WordDocument(paragraph);

// Export docx
doc.SaveAs("document.docx");
