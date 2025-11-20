# Adding a Shadow Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-shadow-effect/>***


Applying a shadow effect to text is an effective way to add depth and visual distinction. This technique involves creating a shadow behind the text that is slightly offset, making it appear as if the text is elevated above the background.

## Quickstart: Implement a Shadow Effect with Just One Line 

You can quickly apply a shadow effect to text in a Word document using IronWord with a single line of code. This method is perfect for developers seeking immediate results without extensive configuration.

```cs
:title=Simplified Shadow Effect Application with IronWord
new IronWord.WordDocument().AddText("Shadow!").Style = new IronWord.Models.TextStyle { TextEffect = new IronWord.Models.TextEffect { ShadowEffect = IronWord.Models.Shadow.OuterShadow1 } };
```

## Detailed Guide to Adding Shadow Effects

To apply a shadow effect to your text, initialize a **TextStyle** object and set its **ShadowEffect** property. After defining the style, apply it to your text through the **TextEffect** property.

```csharp
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument doc = new WordDocument();

// Define and configure the text style
TextStyle textStyle = new TextStyle();
textStyle.TextEffect = new TextEffect()
{
    ShadowEffect = Shadow.OuterShadow1,
};

// Apply the style to new text
doc.AddText("Hello World").Style = textStyle;

// Save the Word document
doc.SaveAs("shadowEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-shadow-effect/shadow-effect.webp" alt="Add shadow effect" class="img-responsive add-shadow">
    </div>
</div>

## Customizing Shadow Effect Properties

While a predefined shadow can be used, you have the flexibility to customize numerous properties of the shadow effect, allowing for more tailored visual outcomes. Below are the adjustable attributes of the shadow effect:

- **Alignment**
- **BlurRadius**: Specifies the blur radius in points (1/72 inch).
- **DirectionAngle**: Sets the angle of the shadow direction in degrees.
- **DistanceFromText**: Defines how far the shadow is from the text, in points.
- **HorizontalScalingFactor**
- **HorizontalSkewAngle**: Sets the skewing angle of the shadow on the horizontal axis in degrees.
- **SchemeColor**
- **VerticalScalingFactor**
- **VerticalSkewAngle**: Sets the skewing angle of the shadow on the vertical axis in degrees.

```csharp
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Initialize a new Word document
WordDocument doc = new WordDocument();

// Define and configure the text style
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

// Apply the style to new text
doc.AddText("Customized shadow").Style = textStyle;

// Save the Word document
doc.SaveAs("customizedShadowEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-shadow-effect/customized-shadow.webp" alt="Customized shadow effect" class="img-responsive add-shadow">
    </div>
</div>