using IronWord;
namespace IronWord.Examples.HowTo.EditText
{
    public static class Section1
    {
        public static void Run()
        {
            // Load a DOCX document
            WordDocument doc = new WordDocument("raw_document.docx");
            
            // Edit existing text on the first paragraph
            doc.Paragraphs[0].Texts[0].Text = "First paragraph is updated successfully";
            
            // Export docx
            doc.SaveAs("edited_document.docx");
        }
    }
}