using IronWord.Models;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section1
    {
        public static void Run()
        {
            new WordDocument()
              .AddParagraph(new Paragraph(new TextContent("Hello IronWord!")).AddImage(new ImageContent("pic.png")))
              .SaveAs("output.docx");
        }
    }
}