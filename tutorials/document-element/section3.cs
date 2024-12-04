using IronWord.Models;
using IronWord;
namespace ironword.DocumentElement
{
    public class Section3
    {
        public void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument();
            
            // Configure image
            IronWord.Models.Image image = new IronWord.Models.Image("image.jpg");
            image.Width = 200; // In unit pixel
            image.Height = 200; // In unit pixel
            Text textRun = new Text();
            
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