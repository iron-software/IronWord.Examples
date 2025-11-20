using IronWord;
namespace IronWord.Examples.HowTo.ReplaceWords
{
    public static class Section2
    {
        public static void Run()
        {
            // Open existing Word
            WordDocument doc = new WordDocument("sample.docx");
            
            // Replace the first paragraph's old text with new text
            doc.Paragraphs[0].ReplaceText("old text", "new text");
            
            // Save updated Word Document
            doc.SaveAs("updated.docx");
        }
    }
}