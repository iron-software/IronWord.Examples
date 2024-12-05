# How to Apply an Outline Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-text-outline-effect/>***


Adding an outline effect to text introduces a distinct border around each character, significantly enhancing the visual definition and readability. This effect may be tailored in color, thickness, and style to meet specific design requirements. It’s particularly favored in various design disciplines such as graphics, typography, and digital layout to emphasize text over diverse backgrounds or to craft a distinct stylized look.

## Implementing Text Outline Effect

To apply an outline effect, begin by initializing a **TextStyle** object and setting its `TextOutlineEffect` property with a new **TextOutlineEffect** instance. After configuring the desired style, apply it to your text by linking the **TextStyle** object to the `TextEffect` property.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectTextOutlineEffect
{
    public class Section1
    {
        public void ApplyOutlineEffect()
        {
            // Initialize a new Word document
            WordDocument document = new WordDocument();
            
            // Configure the text style
            TextStyle style = new TextStyle();
            style.TextEffect = new TextEffect()
            {
                TextOutlineEffect = TextOutlineEffect.DefaultEffect,
            };
            
            // Assign style to text
            document.AddText("Hello World").Style = style;
            
            // Save the styled document
            document.SaveAs("textOutlineEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/text-outline-effect.webp" alt="Add text outline effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Text Outline Effect

The text outline effect can be customized with several properties, each catering to different design requirements. Below are some of the key properties and their purposes:

- **PenAlignment**: Determines the alignment of the pen for the outline.
- **LineCapType**: Specifies the cap style at the end of the outline.
- **LineWidth**: Defines the thickness of the outline in points (1/72 inch).
- **CompoundLineType**: The type of compound line style for the outline.
- **LineJoin**: Controls the interaction of connected lines.
- **Color**: Sets the color of the outline.
- **presetLineDash**: Chooses a predefined dash style for the outline.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectTextOutlineEffect
{
    public class Section2
    {
        public void CustomizeOutlineEffect()
        {
            // Instantiate a new Word document
            WordDocument document = new WordDocument();
            
            // Define custom text style
            TextStyle style = new TextStyle();
            style.TextEffect = new TextEffect()
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
            
            // Apply custom style to text
            document.AddText("Customized text outline").Style = style;
            
            // Save the document
            document.SaveAs("customizedTextOutlineEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/customized-text-outline.webp" alt="Customized text outline effect" class="img-responsive add-shadow">
    </div>
</div>