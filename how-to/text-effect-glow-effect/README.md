# Enhancing Text with a Glow Effect

***Based on <https://ironsoftware.com/how-to/text-effect-glow-effect/>***


A glow effect on text equips it with a luminous aura, making it seem as though the text is backlit. This can vastly improve readability while simultaneously catching the viewer's eye.

## Quickstart: Swiftly Apply Glow Effect to Text

Simply create an instance of a Glow object, configure its radius and color, wrap it in a TextEffect, and apply it to your text’s style. This one-liner will instantly display glowing text in your document.

```cs
:title=Quickly Create Glowing Text
someTextElement.Style.TextEffect = new IronWord.Models.TextEffect { GlowEffect = new IronWord.Models.Glow { GlowRadius = 8, GlowColor = System.Drawing.Color.FromArgb(180, 0, 128, 255) } };
```

### Begin with IronWord

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

## Implementing the Glow Effect

To apply a glow effect to the text, begin by establishing a **Glow** object. Configure this object and instantiate a **TextEffect** from it. Assign this to the **TextEffect** property on your text element.

```csharp
using IronWord; // Includes the relevant library

public class TextGlowEffectExample
{
    public void ApplyGlowEffect()
    {
        // Create and set up a new Glow object
        Glow glow = new Glow();
        glow.GlowRadius = 5; // Set the glow effect's radius
        glow.GlowColor = System.Drawing.Color.FromArgb(128, 255, 0, 0); // Define the glow color using ARGB values

        // Construct a TextEffect object to house the glow
        TextEffect textEffect = new TextEffect();
        textEffect.Glow = glow;

        // Link the TextEffect to the text element
        // For instance: someTextElement.TextEffect = textEffect;
        
        // Additional code to save or display the document would be placed here
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect.webp" alt="Illustration of glow effect" class="img-responsive add-shadow">
    </div>
</div>

## Characteristics of Glow Effects

Here are the details of the properties available in glow effects:

- **GlowRadius**: Determines the extent of the glow effect, measured in points (1/72 inch).
- **GlowColor**: Specifies the RGBA color of the glow.

## Examples of Glow Effects

Explore additional examples of the glow effect where you can adjust the ARGB values to specify the opacity and color of the glow.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect-examples.webp" alt="Various cases of glow effects" class="img-responsive add-shadow">
    </div>
</div>