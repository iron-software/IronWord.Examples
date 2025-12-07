using IronWord;
namespace IronWord.Examples.HowTo.AddText
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new document
            WordDocument newDoc = new WordDocument();
            
            // Add text
            newDoc.AddText("Hello, World!");
            
            // Export the document
            newDoc.SaveAs("addtext_new.docx");
        }
    }
}