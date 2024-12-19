# How to Add a Reflection Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-reflection-effect/>***


A reflection effect on text adds a mirrored image of the text just below the original, giving an illusion that the text is reflected on a surface. This creative touch can add dimension and a realistic feel to your graphical displays.

### Introduction to IronWord

---

## Implementing Reflection Effect

To apply a reflection effect, initiate a **TextStyle** object and set up the `ReflectionEffect` within with a **Reflection** instance. This is then applied to the new text by setting the **TextStyle** object as the `TextEffect`.

```cs
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument doc = new WordDocument();

// Define and apply a text style
TextStyle textStyle = new TextStyle();
textStyle.TextEffect = new TextEffect()
{
    ReflectionEffect = new Reflection(),
};

// Insert styled text
doc.AddText("Hello World").Style = textStyle;

// Save the created Word document
doc.SaveAs("reflectionEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/reflection-effect.webp" alt="Add reflection effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Reflection Effect

The reflection effect includes various settings that can be customized to fit different design preferences. Below is a breakdown of each property:

- **SchemeColor**: Access or modify the color scheme of the reflection.
- **HorizontalSkewAngle**: Adjust the horizontal skew angle, measured in degrees.
- **HorizontalScalingFactor**: Change the horizontal scale of the reflection.
- **DistanceFromText**: Set how far the reflection is from the text or other objects, measured in points (1/72 inch).
- **DirectionAngle**: Define the overall direction of the reflection in degrees.
- **FadeDirectionAngle**: Specify the angle at which the reflection fades.
- **EndPosition**: Determine the final position of the reflection.
- **StartPosition**: Set the initial position of the reflection.
- **EndingOpacity**: Adjust the opacity at the end of the reflection.
- **VerticalScalingFactor**: Modify the vertical scale of the reflection.
- **StartingOpacity**: Set the starting opacity of the reflection.
- **Alignment**: Choose how the reflection aligns with the text or object.
- **BlurRadius**: Specify the radius of the blur on the reflection, measured in points.
- **VerticalSkewAngle**: Adjust the vertical skew angle, in degrees.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Initialize a new Word document
WordDocument doc = new WordDocument();

// Define and apply a text style with detailed reflection properties
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

// Insert styled text
doc.AddText("Customized reflection").Style = textStyle;

// Save the configured Word document
doc.SaveAs("customizedReflectionEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-reflection-effect/customized-reflection.webp" alt="Customized reflection effect" class="img-responsive add-shadow">
    </div>
</div>