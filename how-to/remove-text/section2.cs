using IronWord;
namespace IronWord.Examples.HowTo.RemoveText
{
    public static class Section2
    {
        public static void Run()
        {
            // Load a DOCX document
            WordDocument doc = new WordDocument("sample.docx");
            
            // Remove the first paragraph's third textrun
            doc.Paragraphs[0].Texts[2].Remove();
            
            // Export the file
            doc.SaveAs("sample_after_textrun_removal.docx");
        }
    }
}