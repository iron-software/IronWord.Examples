using IronWord;

// Open existing Word
WordDocument doc = new WordDocument("sample.docx");

// Edit existing text
doc.Paragraphs[0].Texts[0].Text = "This is the edited text.";

// Export docx
doc.SaveAs("document.docx");
