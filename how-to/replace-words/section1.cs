using IronWord;
namespace IronWord.Examples.HowTo.ReplaceWords
{
    public static class Section1
    {
        public static void Run()
        {
            IronWord.Document doc = new IronWord.Document("sample.docx");
            doc.ReplaceText("oldText", "newText");
            doc.SaveAs("updated.docx");
        }
    }
}