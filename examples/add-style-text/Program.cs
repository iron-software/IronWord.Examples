using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Load docx
WordDocument doc = new WordDocument("document.docx");

// Configure text
TextContent text = new TextContent();
      text.Text = "Add text using IronWord";
text.Style = new TextStyle()
{
	TextFont = new Font()
	{
		FontFamily = "Caveat",
		FontSize = 72,
	},
	Color = IronWord.Models.Color.Red,
	IsBold = true,
	IsItalic = true,
	Underline = new Underline(),
	Strike = StrikeValue.Strike,
};

Paragraph paragraph = new Paragraph();

// Add text
paragraph.AddText(text);

// Add paragraph
doc.AddParagraph(paragraph);

// Export docx
doc.SaveAs("save_document.docx");
