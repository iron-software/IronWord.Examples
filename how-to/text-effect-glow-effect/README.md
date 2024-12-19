# How to Implement a Glow Effect on Text

***Based on <https://ironsoftware.com/how-to/text-effect-glow-effect/>***


The glow effect on text produces a luminous halo around the letters, making them seem as though they are illuminated. This feature adds a soft radiance to the outline of the typeface, which not only boosts visibility but also captures interest.

<h3>Introducing IronWord</h3>

---

## Implementing a Glow Effect

To add a glow effect to your text, begin by establishing a **Glow** object. Next, use this to generate a **TextEffect** object. Apply this TextEffect to the **TextEffect** property of your text components.

```cs
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument document = new WordDocument();

// Set up the text style
TextStyle format = new TextStyle();
format.TextEffect = new TextEffect()
{
    GlowEffect = new Glow()
    {
        GlowColor = IronWord.Models.Color.Aqua,
        GlowRadius = 10, // Set the glow radius in points
    },
};

// Insert styled text into the document
document.AddText("Hello World").Style = format;

// Save the document with glow effects
document.SaveAs("glowEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect.webp" alt="Add glow effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Glow Effect

The primary properties of the glow effect include:

- **GlowRadius** : Determines how wide the radiant effect spreads, measured in points (1/72 inch).
- **GlowColor** : Allows you to set the hue of the radiance emanating from the text.

## Examples of Glow Effects

Here are additional glow effect samples, where the glow can be specific in ARGB values, starting with an alpha value which dictates the transparency of the color.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect-examples.webp" alt="Glow effect examples" class="img-responsive add-shadow">
    </div>
</div>