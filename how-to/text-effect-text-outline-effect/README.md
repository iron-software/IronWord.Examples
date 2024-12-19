# How to Apply an Outline Effect to Text

***Based on <https://ironsoftware.com/how-to/text-effect-text-outline-effect/>***


An outline effect around text provides a distinct border that outlines each character, enhancing both readability and visual appeal. This stylistic feature can be tailored in color, width, and style to fit various design preferences and is widely used in digital graphics, typography, and digital design to ensure text pops on various backgrounds or to achieve a particular stylistic look.

<h3>Getting Started with IronWord</h3>

------------------

## Applying a Text Outline Effect

To implement an outline effect on text, begin by initializing a `TextStyle` object. Set up the `TextEffect` property of this object using a `TextOutlineEffect` instance. Once the style is configured, apply it to any new text by linking the `TextStyle` object to the `TextEffect` attribute.

```cs
using IronWord;
using IronWord.Models;

// Initialize a new Word document
WordDocument document = new WordDocument();

// Configure the text style with outline effect
TextStyle textStyling = new TextStyle();
textStyling.TextEffect = new TextEffect()
{
    TextOutlineEffect = TextOutlineEffect.DefaultEffect,
};

// Apply styled text to the document
document.AddText("Hello World").Style = textStyling;

// Save the document with outline effects
document.SaveAs("StyledTextOutline.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/text-outline-effect.webp" alt="Text outline effect showcase" class="img-responsive add-shadow">
    </div>
</div>

## Text Outline Effect Configuration Options

Below are several properties available for customizing text outline effects to meet specific design requirements:

- **PenAlignment**: Defines the alignment of the outline pen.
- **LineCapType**: Specifies the cap style at the end of lines.
- **LineWidth**: Determines the thickness of the outline (measured in points, where 1 point equals 1/72 inch).
- **CompoundLineType**: Sets the compound line style.
- **LineJoin**: Configures the join style between stroke segments.
- **Color**: Assigns the color of the outline.
- **presetLineDash**: Applies a preset dash pattern.

```cs
using IronWord;
using IronWord.Models;
using IronWord.Models.Enums;

// Initiate a new Word document
WordDocument document = new WordDocument();

// Set up text style with specific outline properties
TextStyle textStyling = new TextStyle();
textStyling.TextEffect = new TextEffect()
{
    TextOutlineEffect = new TextOutlineEffect()
    {
        Color = IronWord.Models.Color.Red,
        CompoundLineType = CompoundLineValues.Double,
        LineCapType = LineCapValues.Round,
        LineJoin = StrokeJoinStyleValues.Bevel,
        LineWidth = 0.3,
        PenAlignment = PenAlignmentValues.Center,
        presetLineDash = PresetLineDashValues.Solid
    },
};

// Attach the custom style to new text
document.AddText("Outlined Text Example").Style = textStyling;

// Output the finalized Word document
document.SaveAs("DetailedTextOutlineEffect.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/text-effect-text-outline-effect/customized-text-outline.webp" alt="Detailed view of customized text outline effect" class="img-responsive add-shadow">
    </div>
</div