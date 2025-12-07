# How to Insert Text into a DOCX File Using IronWord

***Based on <https://ironsoftware.com/how-to/add-text/>***


Incorporating automated text entry into applications is crucial for creating reports, building templates, and populating data dynamically within applications.

This guide will teach you how to seamlessly add text to a DOCX file using IronWord.

### Start Your Journey with IronWord

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Inserting Text

IronWord simplifies the process of inserting text into a DOCX file. This capability can be expanded to include text with various formats, stylized paragraphs, and more intricate document constructs as detailed in the [styling guide](https://ironsoftware.com/csharp/word/how-to/add-style-text/).

```csharp
using IronWord;

// Initialize a new document
WordDocument document = new WordDocument();

// Insert text into the document
document.AddText("Hello, World!");

// Save the new document
document.SaveAs("SimpleTextInsertion.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-text/add-text.webp" alt="Inserting text" class="img-responsive add-shadow">
    </div>
</div>


## Text Insertion Within a Paragraph

Inserting text into a paragraph allows for its integration with other components such as tables, pictures, or formatted text, by treating the paragraph as a container for these elements.

```csharp
using IronWord;

// Start with a blank document
WordDocument doc = new WordDocument();

// Create a paragraph element
Paragraph para = new Paragraph();

// Create text content and add to the paragraph
TextContent textualContent = new TextContent("This is a horse.");
para.AddText(textualContent);

// Create and format an image, then add to the paragraph
ImageContent img = new ImageContent("add-text-add-paragraph.jpg");
img.Width = 100;
img.Height = 100;
para.AddImage(img);

// Appends the paragraph to the document
doc.AddParagraph(para);

// Save the updated document
doc.SaveAs("TextWithParagraph.docx");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/add-text/add-text-add-paragraph.webp" alt="Text insertion within paragraph" class="img-responsive add-shadow">
    </div>
</div>