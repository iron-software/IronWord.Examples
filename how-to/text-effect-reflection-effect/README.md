# How to Implement Reflection Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-reflection-effect/>***


Applying a reflection effect to text generates a mirrored image of the text below the original placement, providing an illusion of the text being reflected on a surface. This stylistic feature enhances the depth and aesthetic appeal of graphical representations.

## Implementing Reflection With Style

To apply a reflection effect to your text, first initialize a **TextStyle** object, then set its **ReflectionEffect** property to a new **Reflection** instance. After configuring the style, apply it to your text by setting the **TextStyle** object to the **TextEffect** property.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectReflectionEffect
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate a new Word document
            WordDocument doc = new WordDocument();
            
            // Set up the text style with reflection
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                ReflectionEffect = new Reflection(),
            };
            
            // Apply the style to the text in the document
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with the applied text effect
            doc.SaveAs("reflectionEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/reflection-effect.webp" alt="Add reflection effect" class="img-responsive add-shadow">
    </div>
</div>

## Customizing Reflection Effect Properties

Reflection effects offer several configurable properties that can be tailored to satisfy specific design needs. Below are detailed explanations for each adjustable attribute:

- **SchemeColor**: Defines the color of the reflection.
- **HorizontalSkewAngle**: Adjusts the skew on the horizontal plane, measured in degrees.
- **HorizontalScalingFactor**: Modifies the scaling on the horizontal plane.
- **DistanceFromText**: Determines how far the reflection is from the text, measured in points.
- **DirectionAngle**: Controls the angle of reflection direction, specified in degrees.
- **FadeDirectionAngle**: Sets the angle at which the reflection effect begins to fade.
- **EndPosition**: Specifies the end position of the reflection effect.
- **StartPosition**: Indicates the start position of the reflection effect.
- **EndingOpacity**: Defines the opacity level at the end of the reflection.
- **VerticalScalingFactor**: Alters the scaling on the vertical plane.
- **StartingOpacity**: Sets the initial opacity of the reflection.
- **Alignment**: Controls where the reflection aligns relative to the text.
- **BlurRadius**: Applies a blur effect, the intensity of which is measured in points.
- **VerticalSkewAngle**: Adjusts the skew on the vertical plane, measured in degrees.

```cs
using IronWord.Models.Enums;
using IronWord;
namespace ironword.TextEffectReflectionEffect
{
    public class Section2
    {
        public void Run()
        {
            // Initialize a new Word document
            WordDocument doc = new WordDocument();
            
            // Define a text style with detailed reflection properties
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
            
            // Apply the styled text to the document
            doc.AddText("Customized reflection").Style = textStyle;
            
            // Save the document showcasing the reflection effect
            doc.SaveAs("customizedReflectionEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/customized-reflection.webp" alt="Customized reflection effect" class="img-responsive add-shadow">
    </div>
</div