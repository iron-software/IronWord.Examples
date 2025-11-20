# Applying Gradient Effects to Text

***Based on <https://ironsoftware.com/how-to/text-effect-gradient-effect/>***


Gradient effects on text create dynamic visual transitions between colors, adding dimensions, enhancing the visual appeal, and making the text visually striking. These effects can either be linear, transitioning colors along a straight path, or radial, emanating from a central point.

## Quickstart: Incorporate Gradient Effects in Text Using IronWord

To quickly incorporate a gradient effect on text using IronWord, you can follow this straightforward example. It demonstrates how to apply a pre-configured gradient to your text, enhancing its visual style in just a few steps.

```cs
:title=Quick Gradient Text Application
var document = new IronWord.WordDocument();
document.AddText("Sample Text").Style = new IronWord.Models.TextStyle(){ TextEffect = new IronWord.Models.TextEffect(){ GradientEffect = IronWord.Models.Gradient.DefaultGray } };
document.SaveAs("gradientTextOutput.docx");
```

## Implementing Gradient Effects

To apply a gradient effect, start by creating a `TextStyle` instance and setting its `GradientEffect` to a desired `Gradient` object. Proceed to apply this style when adding text to your document.

```csharp
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument document = new WordDocument();

// Setup the text style with gradient
TextStyle style = new TextStyle();
style.TextEffect = new TextEffect() {
    GradientEffect = Gradient.DefaultGray,
};

// Apply the style to text
document.AddText("Hello World").Style = style;

// Save the document with gradient effects
document.SaveAs("formattedGradient.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/gradient-effect.webp" alt="Add gradient effect" class="img-responsive add-shadow">
    </div>
</div>

## Detailed Gradient Effect Properties

To fine-tune gradient effects, a variety of properties can be utilized, which are detailed below for your convenience:

**GradientStop**
- **Color**: Determines the color at a specific point in the gradient.
- **StopPoint**: Defines the relative position of this color within the gradient.

These stops are critical points that designate color locations along the gradient path.

**Gradient**
- **StopPoints**: A collection of gradient stops that shape the gradient.
- **LinearShadeScaled**: Indicates if the gradient shading is scaled.
- **LinearShadeAngle**: Specifies the angle of the linear gradient.

```csharp
using IronWord;
using IronWord.Models;
using System.Collections.Generic;

// Start a new Word document
WordDocument document = new WordDocument();

// Define gradient stops
GradientStop initialStop = new GradientStop() {
    Color = IronWord.Models.Color.Aqua,
    StopPoint = 1
};
GradientStop finalStop = new GradientStop() {
    Color = IronWord.Models.Color.OrangeRed,
    StopPoint = 10
};

// Setup text style with a custom gradient
TextStyle textstyle = new TextStyle();
textstyle.TextEffect = new TextEffect()
{
    GradientEffect = new Gradient(){
        StopPoints = new List<GradientStop> { initialStop, finalStop },
        LinearShadeAngle = 45,
        LinearShadeScaled = true,
    }
};

// Apply the styled text to the document
document.AddText("Stylized Text").Style = textstyle;

// Save the document
document.SaveAs("advancedGradient.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/customized-gradient.webp" alt="Customized gradient effect" class="img-responsive add-shadow">
    </div>
</div>

This provides a detailed guide on how to enhance your text with gradient effects using IronWord, from simple applications to advanced customization.