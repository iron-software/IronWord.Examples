# How to Add Reflection Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-reflection-effect/>***


Creating a reflection effect for text involves producing a mirrored image of the text below it, akin to how it would appear reflected on a surface. This can lend a sense of depth and enhance the visual impact of the text in your design.

### Quickstart: Apply Reflection Effect to Text in C#

Using the IronWord library, it's straightforward to implement a reflection effect on text with minimal code. This allows developers to quickly incorporate this feature without the need for extensive setup.

```cs
:title=Apply Reflection Effect Instantly
new IronWord.WordDocument().AddText("Example Text").Style = new IronWord.Models.TextStyle(){ TextEffect = new IronWord.Models.TextEffect(){ ReflectionEffect = new IronWord.Models.Reflection() } };
```

## Implement Reflection Effect

To apply a reflection effect, initiate a `TextStyle` object and set up the `ReflectionEffect` property with a new instance of `Reflection`. Then, apply this style when you add text to your document by setting the `TextStyle` to the `TextEffect` of your text.

```csharp
using IronWord;
using IronWord.Models;

// Instantiate a new Word document
WordDocument doc = new WordDocument();

// Initialize and set up text style
TextStyle textStyle = new TextStyle();
textStyle.TextEffect = new TextEffect()
{
    ReflectionEffect = new Reflection(),
};

// Insert styled text
doc.AddText("Sample Text").Style = textStyle;

// Output the document
doc.SaveAs("StyledText.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/reflection-effect.webp" alt="Add reflection effect" class="img-responsive add-shadow">
    </div>
</div>

## Reflection Effect Properties

The reflection effect can be tailored with a variety of properties, allowing customization to fit different design needs. Here’s a breakdown of these properties and their uses:

- `SchemeColor`: Defines the color used for the reflection.
- `HorizontalSkewAngle`: Specifies the angle for horizontal skewing of the reflection in degrees.
- `HorizontalScalingFactor`: Controls the horizontal scaling size of the reflection.
- `DistanceFromText`: Sets how far the reflection should be from the text, measured in points.
- `DirectionAngle`: Dictates the angle direction of the reflection in degrees.
- `FadeDirectionAngle`: Adjusts the direction of the fading effect for the reflection.
- `EndPosition`: Designates the end point for the reflection.
- `StartPosition`: Indicates the starting point of the reflection.
- `EndingOpacity`: Determines the opacity level at the end of the reflection.
- `VerticalScalingFactor`: Adjusts the vertical scale of the reflection.
- `StartingOpacity`: Sets the initial opacity level of the reflection.
- `Alignment`: Specifies the alignment setting for the reflection.
- `BlurRadius`: Applies a blur effect to the reflection with a specified radius.
- `VerticalSkewAngle`: Specifies the angle for vertical skewing of the reflection.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Create a new Word document instance
WordDocument doc = new WordDocument();

// Configure text style with reflection properties
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

// Add and style text
doc.AddText("Advanced Reflection Example").Style = textStyle;

// Save the final document
doc.SaveAs("AdvancedStyledDoc.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/customized-reflection.webp" alt="Customized reflection effect" class="img-responsive add-shadow">
    </div>
</div>