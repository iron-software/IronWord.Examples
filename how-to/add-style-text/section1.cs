using IronWord;
namespace IronWord.Examples.HowTo.AddStyleText
{
    public static class Section1
    {
        public static void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument("sample.docx");
            
            // Configure text
            TextContent text = new TextContent();
            text.Text = "Add text using IronWord";
            
            // Configure text style settings
            text.Style = new TextStyle()
            {
                TextFont = new Font()
                {
                    FontFamily = "Calibri", // Text Font is "Calibri"
                    FontSize = 24, // Text Size is 24
                },
                Color = Color.Red, // Set text color to red
                IsBold = true,     // Make text bold
                IsItalic = true,   // Make text italic
            	Underline = new Underline(), // Have an underline
                Strike = StrikeValue.DoubleStrike, // No strike-through
            };
            
            Paragraph paragraph = new Paragraph();
            
            // Add text to paragraph
            paragraph.AddText(text);
            
            // Add paragraph to document
            doc.AddParagraph(paragraph);
            
            // Save document
            doc.SaveAs("add-text-style.docx");
        }
    }
}