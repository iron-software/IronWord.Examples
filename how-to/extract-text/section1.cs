using IronWord;
namespace IronWord.Examples.HowTo.ExtractText
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate a new DOCX file
            WordDocument doc = new WordDocument();
            
            // Add text
            doc.AddText("Hello, World!");
            
            // Print extracted text from the document to the console
            Console.WriteLine(doc.ExtractText());
        }
    }
}