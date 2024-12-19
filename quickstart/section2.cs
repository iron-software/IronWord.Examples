using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Overview.Quickstart
{
    public static class Section2
    {
        public static void Run()
        {
            // Create textrun
            Text textRun = new Text("Sample text");
            
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(textRun);
            
            // Create a new Word document
            WordDocument doc = new WordDocument(paragraph);
            
            // Export docx
            doc.SaveAs("document.docx");
        }
    }
}