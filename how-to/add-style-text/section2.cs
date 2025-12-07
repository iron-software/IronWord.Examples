using IronWord;
namespace IronWord.Examples.HowTo.AddStyleText
{
    public static class Section2
    {
        public static void Run()
        {
            // Create document
            WordDocument doc = new WordDocument();
            
            // Add colored text
            TextContent text = new TextContent("This text is olive-colored!");
            text.Style = new TextStyle()
            {
                Color = IronWord.Models.Color.Olive // defining text to be colored olive
            };
            
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            doc.AddParagraph(paragraph);
            
            // Save document
            doc.SaveAs("colored-text.docx");
        }
    }
}