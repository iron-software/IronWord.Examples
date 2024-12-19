using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section1
    {
        public static void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Add text
            Text addText = new Text("Add text using IronWord");
            doc.AddParagraph(new Paragraph(addText));
            
            // Append text
            Text appendText = new Text("The first text.");
            appendText.Append(new Text("The second text."));
            doc.AddParagraph(new Paragraph(appendText));
            
            // Split text
            Text splitText = new Text("Use split to split the sentence.");
            splitText.Split(" ");
            doc.AddParagraph(new Paragraph(splitText));
            
            // Export docx
            doc.SaveAs("textrun.docx");
        }
    }
}