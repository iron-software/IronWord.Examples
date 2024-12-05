# Implementing a Reflection Effect on Text

***Based on <https://ironsoftware.com/how-to/text-effect-reflection-effect/>***


A reflection effect on text adds a mirrored image of the text underneath its original appearance. This visual enhancement mimics the reflection on a polished surface, giving a sense of depth and enhancing the visual appeal of the content.

## Adding a Reflection Effect

To apply a reflection effect to text in your document, you first need to create a **TextStyle** object. After setting up the **ReflectionEffect** property with an instance of the **Reflection** object, assign this style to the text by setting the **TextStyle** object to the TextEffect property.

```cs
using IronWord.Models;
using IronWord;

namespace ironword.TextEffectReflectionEffect
{
    public class Section1
    {
        public void Run()
        {
            // Initialize a new Word document
            WordDocument doc = new WordDocument();
            
            // Configure a new text style
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                ReflectionEffect = new Reflection(),
            };
            
            // Apply style to text
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with reflection effect
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

## Properties of Reflection Effect

A variety of properties are available to customize the reflection effect, catering to different design preferences. Below is a detailed list of each property:

- **SchemeColor**: Specifies the scheme color.
- **HorizontalSkewAngle**: Sets the horizontal skew angle in degrees.
- **HorizontalScalingFactor**: Adjusts the horizontal scaling of the reflection.
- **DistanceFromText**: Defines the separation between the text and its reflection, measured in points.
- **DirectionAngle**: Determines the direction angle of the reflection in degrees.
- **FadeDirectionAngle**: Controls the fading direction of the reflection.
- **EndPosition**: Establishes where the reflection ends.
- **StartPosition**: Marks where the reflection starts.
- **EndingOpacity**: Sets the opacity level at the end of the reflection.
- **VerticalScalingFactor**: Adjusts the vertical scaling.
- **StartingOpacity**: Specifies the initial opacity level.
- **Alignment**: Aligns the reflection relative to the text.
- **BlurRadius**: Adds blur, measured in points.
- **VerticalSkewAngle**: Sets the vertical skew angle in degrees.

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
            
            // Define a custom text style
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
            
            // Apply the custom styled text
            doc.AddText("Customized reflection").Style = textStyle;
            
            // Save the document
            doc.SaveAs("customizedReflectionEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/customized-reflection.webp" alt="Customized reflection effect" class="img-responsive add-shadow">
    </div>
</div>