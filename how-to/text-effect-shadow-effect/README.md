# Applying Shadow Effects to Text in .NET

***Based on <https://ironsoftware.com/how-to/text-effect-shadow-effect/>***


Shadow effects on text create a visual depth that can help text elements stand out on a page. By rendering a shadow, you essentially duplicate the original text as a backdrop with a slight positional offset, thereby manifesting as a shadow that can be styled in many ways.

## Implementing Shadow Effect

To implement a shadow effect in your text, first construct a `TextStyle` object and assign a `Shadow` object to its `ShadowEffect` property. Next, apply this style to your text through the `TextEffect` property on a new text element.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectShadowEffect
{
    public class Section1
    {
        public void Run()
        {
            // Initialize a new Word document
            WordDocument doc = new WordDocument();
            
            // Configure text style with shadow
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                ShadowEffect = Shadow.OuterShadow1,
            };
            
            // Applying styled text
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with shadow effects
            doc.SaveAs("shadowEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-shadow-effect/shadow-effect.webp" alt="Add shadow effect" class="img-responsive add-shadow">
    </div>
</div>

## Configuring Shadow Effect Properties

The shadow effect is highly customizable through its various properties. Each property allows you to tweak the appearance and behavior of the shadow in various ways:

- **Alignment**: Determines where the shadow is positioned relative to the text.
- **BlurRadius**: Adjusts the softness of the shadow's edges, defined in points (1/72 inch).
- **DirectionAngle**: Sets the angular direction of the shadow in degrees.
- **DistanceFromText**: Specifies how far the shadow is from the text, in points.
- **HorizontalScalingFactor**: Adjusts the width scaling of the shadow.
- **HorizontalSkewAngle**: Tilts the shadow horizontally by specified degrees.
- **SchemeColor**: Sets the color of the shadow.
- **VerticalScalingFactor**: Adjusts the height scaling of the shadow.
- **VerticalSkewAngle**: Tilts the shadow vertically by specified degrees.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectShadowEffect
{
    public class Section2
    {
        public void Run()
        {
            // Initialize a new Word document
            WordDocument doc = new WordDocument();
            
            // Configuring text style with advanced shadow settings
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
            
            // Applying the custom styled text
            doc.AddText("Customized shadow").Style = textStyle;
            
            // Save the customized document
            doc.SaveAs("customizedShadowEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-shadow-effect/customized-shadow.webp" alt="Customized shadow effect" class="img-responsive add-shadow">
    </div>
</div>