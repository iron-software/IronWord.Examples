using System;
using IronWord;
namespace IronWord.Examples.HowTo.ReplaceWords
{
    public static class Section4
    {
        public static void Run()
        {
            // Open existing Word
            WordDocument doc = new WordDocument("sample.docx");
            
            // Returns the first TextContent element that contains the specified text.
            Console.WriteLine(doc.FindText("old text"));
        }
    }
}