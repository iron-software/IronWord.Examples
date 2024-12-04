# How to Apply a Glow Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-glow-effect/>***


A glow effect on text surrounds the letters with a luminous halo, making them seem to emit light. This soft radiant outline can improve visibility and draw the viewer's attention, enriching the text's impact.

## Applying a Glow Effect

To apply the glow effect to text, begin by setting up a **Glow** object. Next, create a **TextEffect** object using the earlier configured Glow object, and assign this to the **TextEffect** property of your text element.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectGlowEffect
{
    public class ApplyGlowEffect
    {
        public void Execute()
        {
            // Initialize a new Word document
            WordDocument document = new WordDocument();
            
            // Configure the text style with glow effect
            TextStyle style = new TextStyle();
            style.TextEffect = new TextEffect()
            {
                GlowEffect = new Glow()
                {
                    GlowColor = IronWord.Models.Color.Aqua,
                    GlowRadius = 10,
                },
            };
            
            // Apply the style to text
            document.AddText("Hello World").Style = style;
            
            // Save the document with glow effect
            document.SaveAs("glowEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect.webp" alt="Apply glow effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Glow Effect

Here are the properties associated with the glow effect and what they signify:

- **GlowRadius**: Defines the radius of the glow surrounding the text, measured in points (1/72 inch).
- **GlowColor**: Specifies the color of the glow effect around the text.

## Examples of Glow Effects

We can further explore glow effects by using ARGB (Alpha, Red, Green, Blue) values which include an alpha component that controls opacity.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect-examples.webp" alt="Examples of glow effect" class="img-responsive add-shadow">
    </div>
</div