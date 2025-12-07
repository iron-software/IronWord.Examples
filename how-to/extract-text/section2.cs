using System.IO;
using IronWord;
namespace IronWord.Examples.HowTo.ExtractText
{
    public static class Section2
    {
        public static void Run()
        {
            // Load an existing DOCX file
            WordDocument doc = new WordDocument("document.docx");
            
            // Extract text and assign variables
            string firstParagraph = doc.Paragraphs[0].ExtractText();
            string lastParagraph = doc.Paragraphs.Last().ExtractText();
            
            // Combine the texts
            string newText = firstParagraph + " " + lastParagraph;
            
            // Export the combined text as a new .txt file
            File.WriteAllText("output.txt", newText);
        }
    }
}