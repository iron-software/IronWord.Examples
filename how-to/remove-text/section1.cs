using IronWord;
namespace IronWord.Examples.HowTo.RemoveText
{
    public static class Section1
    {
        public static void Run()
        {
            // Load a DOCX document
            WordDocument doc = new WordDocument("text_document.docx");
            
            // Remove the second paragraph
            doc.Paragraphs[1].Remove();
            
            // Export the file
            doc.SaveAs("text_document_modified.docx");
        }
    }
}