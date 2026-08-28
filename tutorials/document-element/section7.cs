using IronWord.Models;
using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section7
    {
        public static void Run()
        {
            // Load docx
            WordDocument doc = new WordDocument();
            
            // Configure image
            ImageContent image = new ImageContent("image.jpg");
            image.TextWrapBehavior = new IronSoftware.Abstractions.Word.TextWrapSquare(
                0, 0, 0, 0, IronSoftware.Abstractions.Word.TextWrapSide.Both);
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