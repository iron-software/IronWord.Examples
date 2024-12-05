using IronWord;
using IronWord.Models;

// Load docx
WordDocument doc = new WordDocument("document.docx");

// Configure text
Text introText = new Text("This is an example paragraph with italic and bold styling.");

TextStyle italicStyle = new TextStyle()
{
    IsItalic = true
};
Text italicText = new Text("Italic example sentence.");
italicText.Style = italicStyle;

TextStyle boldStyle = new TextStyle()
{
    IsBold = true
};
Text boldText = new Text("Bold example sentence.");
boldText.Style= boldStyle;

Paragraph paragraph = new Paragraph();

// Add text
paragraph.AddText(introText);
paragraph.AddText(italicText);
paragraph.AddText(boldText);

// Add paragraph
doc.AddParagraph(paragraph);

// Export docx
doc.SaveAs("save_document.docx");
