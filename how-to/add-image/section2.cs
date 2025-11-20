using IronWord.Models.Enums;
using IronWord;
namespace IronWord.Examples.HowTo.AddImage
{
    public static class Section2
    {
        public static void Run()
        {
            // initializing docx file
            WordDocument doc = new IronWord.WordDocument();
            
            using (HttpClient client = new HttpClient())
            {
                // Add authentication headers
                client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY_HERE");
                client.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");
            
                // Get image from authenticated endpoint
                Stream authenticatedStream = client.GetStreamAsync("https://api.example.com/secure/image.png");
                doc.AddImage(authenticatedStream);
            }
            
            // Export docx
            doc.SaveAs("added-image-via-http-stream.docx");
        }
    }
}