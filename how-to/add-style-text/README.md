# Enhancing Text Appearance in DOCX with C&#35; Using IronWord

***Based on <https://ironsoftware.com/how-to/add-style-text/>***


When crafting professional and visually appealing documents, the ability to style text is crucial. IronWord provides an extensive API for rich text formatting in DOCX files.

This guide will walk you through the process of applying custom text styles using the `TextStyle` class in IronWord.

<h3>Getting Started with IronWord</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Example: Applying Text Styles

The process of applying text styles in IronWord is intuitive and efficient. Begin by creating a `WordDocument` object alongside a `TextContent` object that contains your text. Configure a new `TextStyle` object for the `Style` attribute of your text, setting properties like `IsBold`, `Color`, and `TextFont`. Further beautify your text with options such as underline or double strikethrough.

To complete the styling, add the text to a `Paragraph`, integrate the paragraph into your document, and then save the styled document.

```csharp
using IronWord;

// Initialize a new document
WordDocument doc = new WordDocument("sample.docx");

// Create and configure text
TextContent text = new TextContent()
{
    Text = "Add text using IronWord",
    Style = new TextStyle()
    {
        TextFont = new Font()
        {
            FontFamily = "Calibri", // Using "Calibri" font
            FontSize = 24,          // Set font size to 24
        },
        Color = Color.Red,        // Text color set to red
        IsBold = true,            // Text is bold
        IsItalic = true,          // Text is italic
        Underline = new Underline(), // Apply underline
        Strike = StrikeValue.DoubleStrike, // Apply double strikethrough
    }
};

Paragraph paragraph = new Paragraph();

// Include text in the paragraph
paragraph.AddText(text);

// Integrate the paragraph into the document
doc.AddParagraph(paragraph);

// Save the styled document
doc.SaveAs("styled-text.docx");
```

### Visual Representation

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/add-style-text/add-style-text-simple.webp" alt="Stylized text in DOCX" class="img-responsive add-shadow">
    </div>
</div>

The `TextStyle` class furnishes all the necessary attributes for customizing font properties, text color, boldness, italicization, and underlining. This capability lets you design documents that are both clean and professional.

<hr>

## Applying Specific Styles

### Text Color

Utilize the `Color` property of `TextStyle` to customize text color using predefined colors from `IronWord.Models.Color` or your own hex values to highlight specific content or adhere to branding guidelines.

```csharp
using IronWord;

// Initiate a new document
WordDocument doc = new WordDocument();

// Add text with specific color
TextContent text = new TextContent("This text is olive-colored!");
text.Style = new TextStyle()
{
    Color = IronWord.Models.Color.Olive // Set text color to olive
};

Paragraph paragraph = new Paragraph();
paragraph.AddText(text);
doc.AddParagraph(paragraph);

// Persist the document
doc.SaveAs("colored-text.docx");
```

### Visual Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/add-style-text/add-style-text-add-text.webp" alt="Colored text in DOCX" class="img-responsive add-shadow">
    </div>
</div>

### Font Family and Size

Alter the appearance of text through the `TextFont` property by selecting a font family and specifying the font size in points, which aids in enforcing document standards and establishing a clear visual hierarchy.

```csharp
using IronWord;

// Create a new document
WordDocument doc = new WordDocument();

// Style text with custom font settings
TextContent text = new TextContent("This text uses Arial at 24pt!");
text.Style = new TextStyle()
{
    TextFont = new IronWord.Models.Font()
    {
        FontFamily = "Arial",   // Choose "Arial" font
        FontSize = 24           // Font size is 24 points
    }
};

Paragraph paragraph = new Paragraph();
paragraph.AddText(text);
doc.AddParagraph(paragraph);

// Save the styled document
doc.SaveAs("font-styled-text.docx");
```

### Visual Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/add-style-text/add-style-text-add-font.webp" alt="Font styled text in DOCX" class="img-responsive add-shadow">
    </div>
</div>

### Bold Text

To emphasize headings or significant details, set the `IsBold` property to `true`.

```csharp
using IronWord;

// Start a new document
WordDocument doc = new WordDocument();

// Create bold styled text
TextContent text = new TextContent("This text is bold!");
text.Style = new TextStyle()
{
    IsBold = true  // Enabling bold styling
};

Paragraph paragraph = a new Paragraph();
paragraph.AddText(text);
doc.AddParagraph(paragraph);

// Document saving
doc.SaveAs("bold-text.docx");
```

### Visual Representation

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/add-style-text/add-style-text-add-bold.webp" alt="Bold text in DOCX" class="img-responsive add-shadow">
    </div>
</div>

### Italic Text

Use the `IsItalic` property set to `true` for applying italic styling, ideal for emphasis, titles, foreign words, or technical terms.

```csharp
using IronWord;

// Initialize a new document
WordDocument doc = a WordDocument();

// Configure italic text
TextContent text = new TextContent("This text is italic.");
text.Style = new TextStyle()
{
    IsItalic = true  // Apply italic styling
};

Paragraph paragraph = a new Paragraph();
paragraph.AddText(text);
doc.AddParagraph(paragraph);

// Save this document
doc.SaveAs("italic-text.docx");
```

### Final Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://www.ironsoftware.com/static-assets/word/how-to/add-style-text/add-style-text-add-italic.webp" alt="Italic text in DOCX" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Explore Further Styling Options

IronWord's `TextStyle` class offers a comprehensive set of styling methods and properties as summarized in the table below to customize your text content to meet specific design and formatting needs.

...

This table and the methods listed provide a wide array of text customization options, enhancing your ability to create text-rich documents programmatically that suit varied requirements.