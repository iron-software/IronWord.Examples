using IronWord;
namespace IronWord.Examples.HowTo.AddTable
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Add a Table in a Flash
            var table = new IronWord.Models.Table(3,4);
            var doc = new IronWord.WordDocument();
            doc.AddTable(table);
            doc.SaveAs("QuickTable.docx");
        }
    }
}