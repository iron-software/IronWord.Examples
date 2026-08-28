using IronWord;
namespace IronWord.Examples.HowTo.ReplaceWords
{
    public static class Section1
    {
        public static void Run()
        {
            WordDocument doc = new WordDocument("sample.docx");
            doc.ReplaceText("oldText", "newText");
            doc.SaveAs("updated.docx");
        }
    }
}