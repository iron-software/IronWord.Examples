using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section3
    {
        public void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument("document.docx");
            
            // Configure image
            IronWord.Models.Image image = new IronWord.Models.Image("image.jpg");
            image.Width = 250; // In unit pixel
            image.Height = 200; // In unit pixel
            Paragraph paragraph = new Paragraph();
            
            // Add image
            paragraph.AddImage(image);
            
            // Add paragraph
            doc.AddParagraph(paragraph);
            
            // Export docx
            doc.SaveAs("save_document.docx");
        }
    }
}