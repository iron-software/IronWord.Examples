# Applying Text Outline Effects to Text

***Based on <https://ironsoftware.com/how-to/text-effect-text-outline-effect/>***


Text outline effects give a distinct border to the characters in your text, elevating legibility or aesthetic appeal. These effects can be modified in color, width, and style to match specific design requirements. Such effects are popular in visual design fields like graphic design, typography, and digital content creation, offering a way for text to prominently stand out against various backgrounds.

## Implementing Text Outline Effects

To apply a text outline effect, you need to initialize a **TextStyle** object and set its `TextOutlineEffect` property with a **TextOutlineEffect** object. Then, incorporate this style into new text by assigning the **TextStyle** to the `TextEffect` property.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectTextOutlineEffect
{
    public class Section1
    {
        public void Run()
        {
            // Initialize new Word document
            WordDocument doc = new WordDocument();
            
            // Setup text style with outline effect
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                TextOutlineEffect = TextOutlineEffect.DefaultEffect,
            };
            
            // Applying styled text
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with outline effect
            doc.SaveAs("textOutlineEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/text-outline-effect.webp" alt="Add text outline effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of Text Outline Effects

The text outline effect is highly customizable with various properties that cater to specific design preferences. Below is a detailed list of these properties along with their functions:

- **PenAlignment**: Defines the alignment of the outline's pen.
- **LineCapType**: Determines the style of the endpoint of the line.
- **LineWidth**: Specifies the thickness of the line, measured in points (1/72 inch).
- **CompoundLineType**: Selects the type of compound line pattern.
- **LineJoin**: Sets the joint style where the lines meet.
- **Color**: Chooses the color of the outline.
- **presetLineDash**: Decides the pattern style of the line dash.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectTextOutlineEffect
{
    public class Section2
    {
        public void Run()
        {
            // Start new Word document
            WordDocument doc = new WordDocument();
            
            // Configure text style with customized outline properties
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
            
            // Insert styled text
            doc.AddText("Customized text outline").Style = textStyle;
            
            // Save the document with new outline settings
            doc.SaveAs("customizedTextOutlineEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/customized-text-outline.webp" alt="Customized text outline effect" class="img-responsive add-shadow">
    </div>
</div>