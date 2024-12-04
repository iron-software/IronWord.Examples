using IronWord.Models;
using IronWord;
namespace ironword.Quickstart
{
    public class Section2
    {
        public void Run()
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