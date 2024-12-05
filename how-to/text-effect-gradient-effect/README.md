# How to Apply Gradient Effects to Text

***Based on <https://ironsoftware.com/how-to/text-effect-gradient-effect/>***


Applying a gradient effect to text means creating a seamless blend from one color to another—or several colors—across text characters or backgrounds. This technique introduces depth, attractiveness, and a dynamic flair, enhancing the visual appeal and making text more prominent. There are two types of gradient effects: linear, where the color transition follows a straight line, and radial, where colors radiate from a center point outward.

## Implementing Gradient Effects

To apply a gradient effect, you must first create a **TextStyle** object and set its GradientEffect property with a **Gradient** object. You then apply this style when adding new text by setting the TextStyle object to the TextEffect property.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectGradientEffect
{
    public class Section1
    {
        public void Run()
        {
            // Instantiate a new Word document
            WordDocument doc = new WordDocument();
            
            // Configure a TextStyle for gradient
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                GradientEffect = Gradient.DefaultGray,
            };
            
            // Apply style to newly added text
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with gradient effect
            doc.SaveAs("gradientEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/gradient-effect.webp" alt="Add gradient effect" class="img-responsive add-shadow">
    </div>
</div>

## Gradient Effect Attributes

Gradient effects come with versatile properties, allowing customization to fit specific design needs. Below is an explanation of some key properties:

**GradientStop**
- **Color**: Sets or retrieves the color at a gradient stop.
- **StopPoint**: Defines the position where this color stops.

A gradient stop is a point in the gradient where the color is defined.

**Gradient**
- **StopPoints**: Manages a collection of gradient stops defining the gradient trajectory.
- **LinearShadeScaled**: Indicates if the linear shade is adjusted to scale.
- **LinearShadeAngle**: Specifies the angle of the linear gradient shading.

```cs
using System.Collections.Generic;
using IronWord;
namespace ironword.TextEffectGradientEffect
{
    public class Section2
    {
        public void Run()
        {
            // Create a new Word document
            WordDocument doc = new WordDocument();
            
            // Define gradient stops
            GradientStop firstGradientStop = new GradientStop()
            {
                Color = IronWord.Models.Color.Aqua,
                StopPoint = 1
            };
            GradientStop secondGradientStop = new GradientStop()
            {
                Color = IronWord.Models.Color.OrangeRed,
                StopPoint = 10
            };
            
            // Configure TextStyle for gradient
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                GradientEffect = new Gradient()
                {
                    StopPoints = new List<GradientStop> { firstGradientStop, secondGradientStop },
                    LinearShadeAngle = 45,
                    LinearShadeScaled = true,
                }
            };
            
            // Apply gradient styled text
            doc.AddText("Hello World").Style = textStyle;
            
            // Export the document with custom gradient settings
            doc.SaveAs("customizedGradientEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-gradient-effect/customized-gradient.webp" alt="Customized gradient effect" class="img-responsive add-shadow">
    </div>
</div>