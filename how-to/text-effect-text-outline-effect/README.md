# Enhancing Text with an Outline Effect

***Based on <https://ironsoftware.com/how-to/text-effect-text-outline-effect/>***


The outline effect on text involves adding a distinct, visible border to each character. This effect is not only visually appealing but also enhances the legibility of text, especially against complex backgrounds. Users can tailor this effect by adjusting the color, width, and style of the outline to meet particular design requirements. This technique is widely used across graphic design, typography, and digital creation to give texts a prominent or artistic flair.

### Instant Overview: Implementing a Standard Text Outline

Effortlessly append a standard outline to your text with IronWord by setting up a `TextStyle` object to utilize `TextOutlineEffect.DefaultEffect`. This method provides a straightforward approach for developers to enhance text appearance promptly.

```cs
:title=Effortlessly Add Text Outline
new IronWord.Models.TextStyle { TextEffect = new IronWord.Models.TextEffect { TextOutlineEffect = IronWord.Models.TextOutlineEffect.DefaultEffect } }
```

## Detailing Text Outline Customization

To apply a specific outline effect, you first need to establish a `TextStyle` object and assign a `TextOutlineEffect`. This style is then applied to your text by setting the `TextStyle` via the `TextEffect` property.

```cs
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument doc = new WordDocument();

// Set up the text style with an outline
TextStyle textStyle = new TextStyle();
textStyle.TextEffect = new TextEffect()
{
    TextOutlineEffect = TextOutlineEffect.DefaultEffect,
};

// Apply the style to new text
doc.AddText("Hello World").Style = textStyle;

// Save the document with outline effects
doc.SaveAs("textOutlineEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/text-outline-effect.webp" alt="Demonstration of text outline effect" class="img-responsive add-shadow">
    </div>
</div>

## Properties of the Text Outline Effect

The text outline effect provides a diverse range of properties that can be customized to fit various aesthetic and functional needs. The properties below are integral to shaping the look and feel of your text’s outline:

- **PenAlignment**: Defines the outline’s alignment.
- **LineCapType**: Specifies the end cap style of the outline line.
- **LineWidth**: Sets the thickness of the outline, measured in points.
- **CompoundLineType**: Determines the type of compound line style.
- **LineJoin**: Controls the style of the line connections.
- **Color**: Chooses the color of the outline.
- **PresetLineDash**: Selects a preset pattern for the line’s dash style.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Start a new Word document
WordDocument doc = new WordDocument();

// Define and configure the text style with specific properties
TextStyle textStyle = new TextStyle();
textStyle.TextEffect = new TextEffect()
{
    TextOutlineEffect = new TextOutlineEffect()
    {
        Color = IronWord.Models.Color.Red,
        CompoundLineType = CompoundLineValues.Double,
        LineCapType = LineCapValues.Round,
        LineJoin = StrokeJoinStyleValues.Bevel,
        LineWidth = 0.3,
        PenAlignment = PenAlignmentValues.Center,
        PresetLineDash = PresetLineDashValues.Solid,
    },
};

// Insert text with the newly created style
doc.AddText("Customized text outline").Style = textStyle;

// Output the document with custom outlines
doc.SaveAs("customizedTextOutlineEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/customized-text-outline.webp" alt="Customized text outline effect" class="img-responsive add-shadow">
    </div>
</div