# Enhancing Text with Gradient Effects

***Based on <https://ironsoftware.com/how-to/text-effect-gradient-effect/>***


Applying a gradient effect to text means transitioning smoothly between colors over the text characters or its background, creating visually striking blends. These effects can introduce depth and vibrancy, making the text more engaging and visually appealing. Gradients can be linear, changing along a straight line, or radial, expanding from the center outward.

## Implementing Gradient Effects

To implement a gradient effect on text, you'll begin by creating a `TextStyle` object and setting up the `GradientEffect` property with a `Gradient` object. Hereafter, any new text added will retain this style through the `TextEffect` property of the `TextStyle`.

```cs
using IronWord.Models;
using IronWord;

namespace ironword.TextEffectGradientEffect
{
    public class ExampleSection
    {
        public void Execute()
        {
            // Initialize a new Word document
            WordDocument document = new WordDocument();
            
            // Configure the text style with gradient
            TextStyle style = new TextStyle();
            style.TextEffect = new TextEffect()
            {
                GradientEffect = Gradient.DefaultGray,
            };
            
            // Add styled text
            document.AddText("Hello World").Style = style;
            
            // Save the document with text having gradient effect
            document.SaveAs("gradientEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/gradient-effect.webp" alt="Gradient effect example" class="img-responsive add-shadow">
    </div>
</div>

## Properties of Gradient Effect

Gradient effects offer various properties that can be tailored to fit different design needs. Below you can see a detailed rundown of these properties:

**GradientStop**
- **Color**: Determines the color at this point in the gradient.
- **StopPoint**: Indicates at what point along the gradient path this color appears.

**Gradient**
- **StopPoints**: A collection of `GradientStop` objects that outline the gradient.
- **LinearShadeScaled**: Indicates if the linear gradient scales with the object.
- **LinearShadeAngle**: Determines the angle at which the linear gradient is applied.

```cs
using System.Collections.Generic;
using IronWord;

namespace ironword.TextEffectGradientEffect
{
    public class ExampleSection2
    {
        public void Execute()
        {
            // Initialize a new Word document
            WordDocument document = new WordDocument();
            
            // Define gradient stops
            GradientStop start = new GradientStop()
            {
                Color = IronWord.Models.Color.Aqua,
                StopPoint = 1
            };
            GradientStop end = new GradientStop()
            {
                Color = IronWord.Models.Color.OrangeRed,
                StopPoint = 10
            };
            
            // Configure the text style with multiple gradient stops
            TextStyle style = new TextStyle();
            style.TextEffect = new TextEffect()
            {
                GradientEffect = new Gradient()
                {
                    StopPoints = new List<GradientStop> { start, end },
                    LinearShadeAngle = 45,
                    LinearShadeScaled = true,
                }
            };
            
            // Add styled text
            document.AddText("Hello World").Style = style;
            
            // Save the document
            document.SaveAs("customizedGradientEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/customized-gradient.webp" alt="Customized gradient effect" class="img-responsive add-shadow">
    </div>
</div>