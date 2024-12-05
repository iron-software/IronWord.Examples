# Applying a Glow Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-glow-effect/>***


A glow effect around text consists of a glowing halo surrounding the characters, making it appear as if they are emitting light. This soft, luminous outline not only makes your text stand out but can also enhance its readability by drawing the viewer's attention.

## Implementing a Glow Effect

Begin by establishing a **Glow** object and configuring it for use. Subsequently, create a **TextEffect** object using the previously configured Glow object. This TextEffect must also be set to the **TextEffect** property of the desired text.

```cs
using IronWord.Models;
using IronWord;
namespace ironword.TextEffectGlowEffect
{
    public class Section1
    {
        public void Run()
        {
            // Initialize a new Word document
            WordDocument doc = new WordDocument();
            
            // Define a new text style
            TextStyle textStyle = new TextStyle();
            textStyle.TextEffect = new TextEffect()
            {
                GlowEffect = new Glow()
                {
                    GlowColor = IronWord.Models.Color.Aqua,
                    GlowRadius = 10, // Set radius to 10 points
                },
            };
            
            // Apply the styled text to the document
            doc.AddText("Hello World").Style = textStyle;
            
            // Save the document with the new style
            doc.SaveAs("glowEffect.docx");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect.webp" alt="Add glow effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Glow Effect

The following are details on the properties related to the glow effect:

- **GlowRadius**: Determines the radius of the glow effect, expressed in points (1/72 inch).
- **GlowColor**: Specifies the shade for the glow effect.

## Additional Examples of Glow Effects

Here are more instances to showcase how flexible the glow effect can be, including the use of ARGB values in setting the color. The 'alpha' value indicates the opacity of the color.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-glow-effect/glow-effect-examples.webp" alt="Glow effect examples" class="img-responsive add-shadow">
    </div>
</div