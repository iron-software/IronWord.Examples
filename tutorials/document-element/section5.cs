using IronWord.Models.Enums;
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
            IronWord.Models.Image image = new IronWord.Models.Image("image.jpg");
            image.WrapText = WrapText.Square;
            image.Width = 100;
            image.Height = 100;
            image.DistanceFromTop = 50;
            
            var position = new ElementPosition();
            position.X = 50;
            position.Y = 50;
            image.Position = position;
            
            Paragraph paragraph = new Paragraph();
            
            // Add image
            paragraph.AddImage(image);
            
            // Add paragraph
            doc.AddParagraph(paragraph);
            
            // Export docx
            doc.SaveAs("document.docx");
        }
    }
}