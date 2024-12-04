using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectShadowEffect
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
                ShadowEffect = new Shadow()
                {
                    Alignment = RectangleAlignmentValues.BottomLeft,
                    BlurRadius = 5,
                    DirectionAngle = 45,
                    DistanceFromText = 3,
                    HorizontalScalingFactor = 100,
                    VerticalScalingFactor = 100,
                    HorizontalSkewAngle = 0,
                    SchemeColor = IronWord.Models.Color.Aqua,
                    VerticalSkewAngle = 0,
                },
            };
            
            // Add text with style
            doc.AddText("Customized shadow").Style = textStyle;
            
            // Export new Word document
            doc.SaveAs("customizedShadowEffect.docx");
        }
    }
}