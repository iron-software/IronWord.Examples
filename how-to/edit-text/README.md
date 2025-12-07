# How to Modify Text in Word Documents Using C#

***Based on <https://ironsoftware.com/how-to/edit-text/>***


Modifying text in Word documents is essential for updating content and managing document revisions. IronWord allows you to directly manipulate the text within paragraph runs, enabling precise edits to DOCX files programmatically.

This guide provides step-by-step instructions on how to modify text in DOCX documents using IronWord.

<h3>Begin with IronWord</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!


## Text Editing Example

To modify text within a Word document, start by loading the file and selecting the desired paragraph. The paragraph provides access to a `Texts` array, where the `Texts[0]` property points to the first segment of text within that paragraph. Make the necessary text changes, then save the file as a new DOCX document.

If a paragraph includes different formatting within it, each style segment creates a separate text segment or run.

```csharp
using IronWord;

// Initialize a DOCX document
WordDocument doc = new WordDocument("raw_document.docx");

// Update the text in the first paragraph
doc.Paragraphs[0].Texts[0].Text = "First paragraph is updated successfully";

// Save the modified document
doc.SaveAs("edited_document.docx");
```

### Before the Change

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/edit-text/edit-text-simple-before.webp" alt="Document before text modification" class="img-responsive add-shadow">
    </div>
</div>

### After the Change

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/edit-text/edit-text-simple-after.webp" alt="Document after text modification" class="img-responsive add-shadow">
    </div>
</div>

## Modify a Specific Text Run

In situations where a paragraph includes multiple text runs, differentiated by their formatting, targeting a specific run is key. Indexed using zero-based array indexing, `Texts[0]` refers to the first run. In the example below, the second text run of the fourth paragraph is altered.

```csharp
using IronWord;

// Open the DOCX document
WordDocument doc = new WordDocument("text_document.docx");

// Change the second text run in the 4th paragraph
doc.Paragraphs[3].Texts[1].Text = "Edited the textrun successfully within the same paragraph";

// Commit changes
doc.SaveAs("text_document.docx");
```

### Before the Change

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/edit-text/edit-text-text-run-before.webp" alt="Document before text run modification" class="img-responsive add-shadow">
    </div>
</div>

### After the Change

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/edit-text/edit-text-text-run-after.webp" alt="Document after text run modification" class="img-responsive add-shadow">
    </div>
</div>