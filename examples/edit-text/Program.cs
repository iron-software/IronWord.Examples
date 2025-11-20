using IronWord;

// Open existing Word
WordDocument doc = new WordDocument("sample.docx");

// Edit existing text
doc.Paragraphs[0].ReplaceText("old text.", "This is the edited text.");

      // Edit text by retrieving the old text
      doc.Paragraphs[1].ReplaceText(doc.Paragraphs[1].Texts[1].Text, "Updated content for the second paragraph.");

      // Export docx
      doc.SaveAs("document.docx");
