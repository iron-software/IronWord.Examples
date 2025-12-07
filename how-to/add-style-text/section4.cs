using IronWord;
namespace IronWord.Examples.HowTo.AddStyleText
{
    public static class Section4
    {
        public static void Run()
        {
            // Create document
            WordDocument doc = new WordDocument();
            
            // Add bold text
            TextContent text = new TextContent("this is bold!");
            text.Style = new TextStyle()
            {
                IsBold = true  // Make text bold
            };
            
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            doc.AddParagraph(paragraph);
            
            // Save document
            doc.SaveAs("bold-text.docx");
        }
    }
}