using IronWord;
namespace IronWord.Examples.HowTo.AddText
{
    public static class Section2
    {
        public static void Run()
        {
            // Create a blank document
            WordDocument paragraphDoc = new WordDocument();
            
            // Instantiate a paragraph object
            Paragraph paragraph = new Paragraph();
            
            // Add text to paragraph
            TextContent text = new TextContent("This is a horse.");
            paragraph.AddText(text);
            
            // Add image to paragraph
            ImageContent image = new ImageContent("add-text-add-paragraph.jpg");
            image.Width = 100;
            image.Height = 100;
            paragraph.AddImage(image);
            
            // Add paragraph to document
            paragraphDoc.AddParagraph(paragraph);
            
            // Export the document
            paragraphDoc.SaveAs("addtext_paragraph.docx");
        }
    }
}