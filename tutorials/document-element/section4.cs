using System;
using IronWord;
namespace IronWord.Examples.Tutorial.DocumentElement
{
    public static class Section4
    {
        public static void Run()
        {
            // Open existing Word
            WordDocument doc = new WordDocument("Accent1TextThemcolor.docx");
            
            TextContent content = doc.Paragraphs[0].Texts[0];
            
            // This will show the R G B A of the themecolor
            var filledColor = content.FillColor;
            
            // Print the filled color variable to the console
            Console.WriteLine(filledColor);
        }
    }
}