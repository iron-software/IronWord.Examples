using IronWord;
namespace IronWord.Examples.HowTo.ExtractText
{
    public static class Section3
    {
        public static void Run()
        {
            // Load the API statistics document
            WordDocument apiStatsDoc = new WordDocument("api-statistics.docx");
            
            // Extract text from the 1st table, 4th column and 2nd row
            string extractedValue = apiStatsDoc.Tables[0].Rows[2].Cells[3].ExtractText();
            
            // Print extracted value
            Console.WriteLine($"Target success rate: {extractedValue}");
        }
    }
}