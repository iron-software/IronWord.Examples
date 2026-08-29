using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section1
    {
        public static void Run()
        {
            Paragraph paragraph = new Paragraph(new TextContent("Hello IronWord!"));
            paragraph.AddImage(new ImageContent("pic.png"));

            WordDocument doc = new WordDocument();
            doc.AddParagraph(paragraph);
            doc.SaveAs("output.docx");
        }
    }
}