using IronWord.Models;
using IronWord;
namespace IronWord.Examples.HowTo.TextEffectReflectionEffect
{
    public static class Section1
    {
        public static void Run()
        {
            // Create new Word document
            WordDocument doc = new WordDocument();
            
            // Create and configure text style
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                ReflectionEffect = new Reflection(),
            };
            
            // Add text with style
            doc.AddText("Hello World").Style = textStyle;
            
            // Export new Word document
            doc.SaveAs("reflectionEffect.docx");
        }
    }
}