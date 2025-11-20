using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Quickly Add & Style Text or Images with IronWord
            new WordDocument()
              .AddParagraph(new Paragraph(new TextContent("Hello IronWord!")).AddImage(new ImageContent("pic.png")))
              .SaveAs("output.docx");
        }
    }
}