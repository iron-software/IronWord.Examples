using IronWord;
namespace IronWord.Examples.HowTo.RemoveText
{
    public static class Section3
    {
        public static void Run()
        {
            // Load the document
            WordDocument doc = new WordDocument("sample.docx");
            
            // Find and remove erroneous text
            var textToRemove = doc.FindText("ERRONEOUS TEXT IS HERE.");
            textToRemove?.Remove();
            
            // Save the cleaned document
            doc.SaveAs("sample_cleaned.docx");
        }
    }
}