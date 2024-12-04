using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectTextOutlineEffect
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
                TextOutlineEffect = new TextOutlineEffect()
                {
                    Color = IronWord.Models.Color.Red,
                    CompoundLineType = CompoundLineValues.Double,
                    LineCapType = LineCapValues.Round,
                    LineJoin = StrokeJoinStyleValues.Bevel,
                    LineWidth = 0.3,
                    PenAlignment = PenAlignmentValues.Center,
                    presetLineDash = PresetLineDashValues.Solid
                },
            };
            
            // Add text with style
            doc.AddText("Customized text outline").Style = textStyle;
            
            // Export new Word document
            doc.SaveAs("customizedTextOutlineEffect.docx");
        }
    }
}