using IronWord;
namespace IronWord.Examples.HowTo.EditText
{
    public static class Section2
    {
        public static void Run()
        {
            // Load the document
            WordDocument doc = new WordDocument("text_document.docx");
            
            // Edit second text run in the 4th paragraph
            doc.Paragraphs[3].Texts[1].Text = "Edited the textrun successfully within the same paragraph";
            
            // Save to the same file
            doc.SaveAs("text_document.docx");
        }
    }
}