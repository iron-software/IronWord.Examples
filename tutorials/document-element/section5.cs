using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section5
    {
        public static void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument();
            
            // Configure image
            ImageContent image = new ImageContent("image.jpg");
            image.Width = 200; // In unit pixel
            image.Height = 200; // In unit pixel
            TextContent textRun = new TextContent();
            
            // Add image
            Paragraph para = new Paragraph(textRun);
            para.AddImage(image);
            
            // Add paragraph
            doc.AddParagraph(new Paragraph(textRun));
            
            // Export docx
            doc.SaveAs("save_document.docx");
        }
    }
}