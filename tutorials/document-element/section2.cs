using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section2
    {
        public static void Run()
        {
            WordDocument doc = new WordDocument();
            
            // Add text
            TextContent addText = new TextContent("Add text using IronWord");
            doc.AddParagraph(new Paragraph(addText));
            
            // Append text
            TextContent appendText = new TextContent("The first text.");
            appendText.Append(new TextContent("The second text."));
            doc.AddParagraph(new Paragraph(appendText));
            
            // Split text
            TextContent splitText = new TextContent("Use split to split the sentence.");
            splitText.Split(" ");
            doc.AddParagraph(new Paragraph(splitText));
            
            // Export docx
            doc.SaveAs("textrun.docx");
        }
    }
}