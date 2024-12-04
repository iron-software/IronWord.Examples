# How to Implement a Shadow Effect on Text

***Based on <https://ironsoftware.com/how-to/text-effect-shadow-effect/>***


Adding a shadow to text is an effective way to give it depth and make it stand out. This technique involves creating a slightly offset duplicate of the original text behind it, known as the shadow, which helps to achieve a visually engaging effect. This shadow can be finely tuned through various parameters to suit specific design needs.

## Implementing a Shadow Effect

To apply a shadow effect to text, you first need to instantiate a `TextStyle` object and set its `ShadowEffect` property to a new `Shadow` object. Then, apply this style to the text by setting the `TextStyle` object to the `TextEffect` property of the text element.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectShadowEffect
{
    public class Section1
    {
        public void Run()
        {
            // Initialize a new document for text
            WordDocument doc = new WordDocument();
            
            // Configure the text style
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                ShadowEffect = Shadow.OuterShadow1,
            };
            
            // Assign the styled text
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with the new style
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

The shadow effect offers several adjustable properties to customize its appearance. These properties let you tweak everything from the shadow's alignment and blurriness to its skew angles and color. Below is a listing of these properties along with their respective descriptions:

- **Alignment**: Controls where the shadow is positioned relative to the text.
- **BlurRadius**: Sets the blurring effect's radius, in points, for a softer shadow.
- **DirectionAngle**: Defines the angle of the shadow's direction in degrees.
- **DistanceFromText**: Specifies how far the shadow extends from the text, measured in points.
- **HorizontalScalingFactor**: Adjusts the width of the shadow relative to the text.
- **HorizontalSkewAngle**: Alters the horizontal skewing of the shadow's angle in degrees.
- **SchemeColor**: Determines the color of the shadow.
- **VerticalScalingFactor**: Adjusts the height of the shadow relative to the text.
- **VerticalSkewAngle**: Alters the vertical skewing of the shadow's angle in degrees.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectShadowEffect
{
    public class Section2
    {
        public void Run()
        {
            // Start a new document
            WordDocument doc = new WordDocument();
            
            // Detailed text styling
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
            
            // Applying custom shadow and saving
            doc.AddText("Customized shadow").Style = textStyle;
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