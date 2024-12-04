using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectReflectionEffect
{
    public class Section2
    {
        public void Run()
        {
            // Create new Word document
            WordDocument doc = new WordDocument();
            
            // Create and configure text style
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                ReflectionEffect = new Reflection()
                {
                    Alignment = RectangleAlignmentValues.BottomLeft,
                    BlurRadius = 5,
                    DirectionAngle = 90,
                    DistanceFromText = 5,
                    EndingOpacity = 100,
                    EndPosition = 10,
                    FadeDirectionAngle = 90,
                    HorizontalScalingFactor = 100,
                    HorizontalSkewAngle = 0,
                    SchemeColor = IronWord.Models.Color.Gold,
                    StartingOpacity = 0,
                    StartPosition = 0,
                    VerticalScalingFactor = -100,
                    VerticalSkewAngle = 0,
                },
            };
            
            // Add text with style
            doc.AddText("Customized reflection").Style = textStyle;
            
            // Export new Word document
            doc.SaveAs("customizedReflectionEffect.docx");
        }
    }
}