using System.Collections.Generic;
using IronWord;
namespace IronWord.Examples.HowTo.TextEffectGradientEffect
{
    public static class Section2
    {
        public static void Run()
        {
            // Create new Word document
            WordDocument doc = new WordDocument();
            
            // Create gradient stops
            GradientStop firstGradientStop = new GradientStop()
            {
                Color = IronWord.Models.Color.Aqua,
                StopPoint = 1
            };
            GradientStop secondGradientStop = new GradientStop()
            {
                Color = IronWord.Models.Color.OrangeRed,
                StopPoint = 10
            };
            
            // Create and configure text style
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                GradientEffect = new Gradient()
                {
                    StopPoints = new List<GradientStop> { firstGradientStop, secondGradientStop },
                    LinearShadeAngle = 45,
                    LinearShadeScaled = true,
                }
            };
            
            // Add text with style
            doc.AddText("Hello World").Style = textStyle;
            
            // Export new Word document
            doc.SaveAs("customizedGradientEffect.docx");
        }
    }
}