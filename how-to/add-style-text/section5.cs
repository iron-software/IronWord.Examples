using IronWord;
namespace IronWord.Examples.HowTo.AddStyleText
{
    public static class Section5
    {
        public static void Run()
        {
            // Create document
            WordDocument doc = new WordDocument();
            
            // Add italic text
            TextContent text = new TextContent("this is italic.");
            text.Style = new TextStyle()
            {
                IsItalic = true  // Make text italic
            };
            
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            doc.AddParagraph(paragraph);
            
            // Save document
            doc.SaveAs("italic-text.docx");
        }
    }
}