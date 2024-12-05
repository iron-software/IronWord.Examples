using IronWord;

// Open existing Word
WordDocument doc = new WordDocument("sample.docx");

// Remove textrun
doc.Paragraphs[0].RemoveChildren(doc.Paragraphs[0].Texts[0]);

// Export docx
doc.SaveAs("document.docx");
