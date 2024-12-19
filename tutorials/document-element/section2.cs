using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section2
    {
        public static void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument("document.docx");
            
            // Configure text
            Text textRun = new Text();
            textRun.Text = "Add text using IronWord";
            textRun.Style = new TextStyle()
            {
                TextFont = new Font()
                {
                    FontFamily = "Caveat",
                    FontSize = 72,
                },
                Color = Color.Red,
                IsBold = true,
                IsItalic = true,
                Underline = new Underline(),
                Strike = StrikeValue.Strike,
            };
            
            Paragraph paragraph = new Paragraph();
            
            // Add text
            paragraph.AddText(textRun);
            
            // Add paragraph
            doc.AddParagraph(paragraph);
            
            // Export docx
            doc.SaveAs("save_document.docx");
        }
    }
}