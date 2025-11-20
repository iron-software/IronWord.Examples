using IronWord;
using IronWord.Models;

// Load docx
WordDocument doc = new WordDocument("document.docx");

// Configure text
TextContent introText = new TextContent("This is an example paragraph with italic and bold styling.");

TextStyle italicStyle = new TextStyle()
{
    IsItalic = true
};
TextContent italicText = new TextContent("Italic example sentence.");
italicText.Style = italicStyle;

TextStyle boldStyle = new TextStyle()
{
    IsBold = true
};
TextContent boldText = new TextContent("Bold example sentence.");
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
