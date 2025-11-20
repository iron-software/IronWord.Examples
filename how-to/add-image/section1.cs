using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.HowTo.AddImage
{
    public static class Section1
    {
        public static void Run()
        {
            // initializing docx file
            WordDocument doc = new IronWord.WordDocument();
            
            // instantiating image file
            IronWord.Models.ImageContent image = new IronWord.Models.ImageContent("sample-image.jpg");
            
            // modifying image properties
            image.Width = 200;
            image.Height = 200;
            
            // AddImage function saving the image
            doc.AddImage(image);
            
            // Save and export the file
            doc.SaveAs("inserted-image.docx");
        }
    }
}