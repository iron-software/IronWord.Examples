# How to Apply a Gradient Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-gradient-effect/>***


Applying a gradient effect to text means creating a seamless color transition either across the characters or the background of the text, which results in a visual blend from one color to another or among multiple colors. This technique can significantly enhance text attractiveness by adding visual depth and a vibrant look. There are two types of gradient effects: linear, where the color changes along a straight line, and radial, where the color radiates from a central point.

<h3>Getting Started with IronWord</h3>

-------------------------------

## Implementing the Gradient Effect

Begin by initializing a **TextStyle** object. Populate its `GradientEffect` property with a **Gradient** object to define the gradient style. Then, create text with this styled effect by setting the **TextStyle** object to the `TextEffect` property.

```cs
using IronWord;
using IronWord.Models;

// Initialize a new Word document instance
WordDocument document = new WordDocument();

// Define and configure a new text style
TextStyle textStyling = new TextStyle();
textStyling.TextEffect = new TextEffect()
{
    GradientEffect = Gradient.DefaultGray,  // Default gray gradient effect
};

// Apply the text style and add text
document.AddText("Hello World").Style = textStyling;

// Save the Word document with gradient styling
document.SaveAs("gradientEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/gradient-effect.webp" alt="Add gradient effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Gradient Effect

The gradient effect encompasses several attributes that can be adjusted to fit various design needs. Below is a detailed list of these properties:

**GradientStop**
- **Color**: This specifies the color at a gradient stop.
- **StopPoint**: This defines the location of the gradient stop within the gradient.

Gradient stops mark the points within a gradient where the colors transition.

**Gradient**
- **StopPoints**: These are the sequence of gradient stops that define the gradient's composition.
- **LinearShadeScaled**: This indicates if the linear shade is scaled proportionally.
- **LinearShadeAngle**: Specifies the angle for the linear shade.

```cs
using IronWord;
using IronWord.Models;
using System.Collections.Generic;

// Initialize a new Word document instance
WordDocument document = new WordDocument();

// Define gradient stop points
GradientStop firstStop = new GradientStop()
{
    Color = IronWord.Models.Color.Aqua,
    StopPoint = 1  // Beginning of gradient
};
GradientStop secondStop = new GradientStop()
{
    Color = IronWord.Models.Color.OrangeRed,
    StopPoint = 10  // End of gradient
};

// Establish text style with gradient effects
TextStyle styledText = new TextStyle();
styledText.TextEffect = new TextEffect()
{
    GradientEffect = new Gradient()
    {
        StopPoints = new List<GradientStop> { firstStop, secondStop },
        LinearShadeAngle = 45,
        LinearShadeScaled = true
    }
};

// Apply and add styled text
document.AddText("Hello World").Style = styledText;

// Save the document with customized gradient effects
document.SaveAs("customizedGradientEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/customized-gradient.webp" alt="Customized gradient effect" class="img-responsive add-shadow">
    </div>
</div>