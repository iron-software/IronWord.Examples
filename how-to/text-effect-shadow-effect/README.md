# How to Apply a Shadow Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-shadow-effect/>***


Applying a shadow effect to text is an effective way to add depth and make the text stand out. This effect simulates a shadow by creating a copy of the original text, slightly shifted, to give the illusion of depth. You can adjust the shadow in multiple ways to achieve various visual impacts.

<h3>Introduction to IronWord</h3>

-------------------------------

## Implementing the Shadow Effect

To implement a shadow effect, start by creating a `TextStyle` instance and set the `ShadowEffect` property with an instance of `Shadow`. Then, apply this style to your text by linking the `TextStyle` to the `TextEffect` property.

```cs
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument document = new WordDocument();

// Configure the text style
TextStyle style = new TextStyle();
style.TextEffect = new TextEffect()
{
    ShadowEffect = Shadow.OuterShadow1,
};

// Insert styled text into the document
document.AddText("Hello World").Style = style;

// Save the document with the shadow effect
document.SaveAs("shadowEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-shadow-effect/shadow-effect.webp" alt="Add shadow effect" class="img-responsive add-shadow">
    </div>
</div>

## Customizing Shadow Effect Attributes

The shadow effect is highly versatile, allowing you to customize its various attributes. Below are the adjustable properties:

- **Alignment**: Configures the shadow's alignment.
- **BlurRadius**: Sets the blur radius of the shadow, measured in points (1/72 inch).
- **DirectionAngle**: Defines the angle of the shadow's direction in degrees.
- **DistanceFromText**: Specifies the shadow's distance from the text, measured in points.
- **HorizontalScalingFactor**: Adjusts the horizontal scaling factor.
- **HorizontalSkewAngle**: Sets the angle of horizontal skew, measured in degrees.
- **SchemeColor**: Chooses the scheme color for the shadow.
- **VerticalScalingFactor**: Adjusts the vertical scaling factor.
- **VerticalSkewAngle**: Sets the angle of vertical skew, measured in degrees.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Create a Word document
WordDocument document = new WordDocument();

// Setup the text style with shadow effects
TextStyle style = new TextStyle();
style.TextEffect = new TextEffect()
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

// Insert the customized text with shadow
document.AddText("Customized shadow").Style = style;

// Save the document
document.SaveAs("customizedShadowEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-shadow-effect/customized-shadow.webp" alt="Customized shadow effect" class="img-responsive add-shadow">
    </div>
</div>