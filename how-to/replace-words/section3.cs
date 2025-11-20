using IronWord;
namespace IronWord.Examples.HowTo.ReplaceWords
{
    public static class Section3
    {
        public static void Run()
        {
            // Open existing Word
            WordDocument doc = new WordDocument("sample.docx");
            
            // Loop through each paragraph to find and replace text
            for (int i = 0; i < doc.Paragraphs.Count; i++)
            {
                // Replace all occurrences of "old text" with "new text" in the current paragraph
                doc.Paragraphs[i].ReplaceText("old text", "new text");
            }
            
            // Save updated Word Document
            doc.SaveAs("updated.docx");
        }
    }
}