using IronWord;
namespace IronWord.Examples.HowTo.AddStyleText
{
    public static class Section3
    {
        public static void Run()
        {
            // Create document
            WordDocument doc = new WordDocument();
            
            // Add text with custom font family and size
            TextContent text = new TextContent("This text uses Arial at 24pt!");
            text.Style = new TextStyle()
            {
                TextFont = new IronWord.Models.Font()
                {
                    FontFamily = "Arial",  // Set font family
                    FontSize = 24          // Set font size in points
                }
            };
            
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            doc.AddParagraph(paragraph);
            
            // Save document
            doc.SaveAs("font-styled-text.docx");
        }
    }
}