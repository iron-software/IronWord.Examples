using IronWord.Models;
using IronWord;
namespace IronWord.Examples.HowTo.TextEffectShadowEffect
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
                ShadowEffect = Shadow.OuterShadow1,
            };
            
            // Add text with style
            doc.AddText("Hello World").Style = textStyle;
            
            // Export new Word document
            doc.SaveAs("shadowEffect.docx");
        }
    }
}