using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.HowTo.AddImage
{
    public static class Section3
    {
        public static void Run()
        {
            // initializing docx file
            WordDocument doc = new IronWord.WordDocument();
            
            // instantiating image file
            IronWord.Models.ImageContent image = new IronWord.Models.ImageContent("sample-image.tiff");
            
            // modifying the aspect ratio by introducing custom width
            image.Width = 800;
            image.Height = 200;
            
            // AddImage function saving the image
            doc.AddImage(image);
            
            // Save and export the file
            doc.SaveAs("custom-size-image.docx");
        }
    }
}