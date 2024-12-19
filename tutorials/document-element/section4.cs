using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section4
    {
        public static void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument();
            
            Paragraph paragraph = new Paragraph();
            
            // Add image
            paragraph.AddImage("image.jpg");
            
            // Add paragraph
            doc.AddParagraph(paragraph);
            
            // Export docx
            doc.SaveAs("document.docx");
        }
    }
}