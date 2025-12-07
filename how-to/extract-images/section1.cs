using IronWord;
namespace IronWord.Examples.HowTo.ExtractImages
{
    public static class Section1
    {
        public static void Run()
        {
            // Load an existing Word document
            WordDocument doc = new WordDocument("embedded_images.docx");
            
            // Extract all images from the document
            var images = doc.ExtractImages();
            
            // Iterate through extracted images
            int count = 0;
            foreach (var image in images)
            {
                // Save each image to disk
                string fileName = $"extracted-image-{count}.png";
                image.SaveAs(fileName);
            
                Console.WriteLine($"Extracted image {count}:");
                Console.WriteLine($"Width: {image.Width}");
                Console.WriteLine($"Height: {image.Height}");
                Console.WriteLine($"Saved as: {fileName}");
            
                count++;
            }
            
            Console.WriteLine($"Total images extracted: {count}");
        }
    }
}