# Removing Text from DOCX in C#

***Based on <https://ironsoftware.com/how-to/remove-text/>***


Extracting text from DOCX files is an essential task in document management, allowing developers to neatly redact or clean up contents from Word documents. This guide will cover several techniques to strip paragraphs, text runs, and diverse elements using IronWord, all while preserving the document's overall structure.

<h3>Starting with IronWord</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Example of Text Removal

Consider the scenario where you wish to delete a specific paragraph from a Word document. You can do this by selecting the paragraph through the `Paragraphs` collection using an index. In this example, deleting the paragraph at index 1 will remove its contents along with any associated formatting, and the document will reorganize itself accordingly.

```csharp
using IronWord;

// Initialize a DOCX document
WordDocument doc = new WordDocument("text_document.docx");

// Erase the second paragraph
doc.Paragraphs[1].Remove();

// Save the modified file
doc.SaveAs("text_document_modified.docx");
```

### Image Before Paragraph Removal

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/remove-text/remove-text-simple-before.webp" alt="Document before paragraph removal" class="img-responsive add-shadow">
    </div>
</div>

### Image After Paragraph Removal

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/remove-text/remove-text-simple-after.webp" alt="Document after paragraph removal" class="img-responsive add-shadow">
    </div>
</div>

## Removing a Specified Text Run

A single paragraph might include several text runs, each representing a sequence of characters sharing the same formatting. To eliminate particular formatted segments within a paragraph, locate the desired text run through the `Texts` collection by its index. Here, we remove the third text run (index 2) from the first paragraph.

```csharp
using IronWord;

// Open a DOCX document
WordDocument doc = new WordDocument("sample.docx");

// Delete the third text run from the first paragraph
doc.Paragraphs[0].Texts[2].Remove();

// Output the edited document
doc.SaveAs("sample_after_textrun_removal.docx");
```

### Before Text Run is Removed

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/remove-text/remove-text-text-run-before.webp" alt="Document before text run removal" class="img-responsive add-shadow">
    </div>
</div>

### After Text Run is Removed

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/remove-text/remove-text-text-run-after.webp" alt="Document after text run removal" class="img-responsive add-shadow">
    </div>
</div>

## Example of Finding and Removing Text

The method `FindText` is employed to dynamically search and delete text in a document based on its content, rather than its location. It's particularly useful for disposing of incorrect text, filler content, or specific words regardless of their position in the document. If the method finds the text, it allows you to remove it safely after verifying it is not `null`.

```csharp
using IronWord;

// Open the document
WordDocument doc = new WordDocument("sample.docx");

// Search for and delete incorrect text
var textToRemove = doc.FindText("ERRONEOUS TEXT IS HERE.");
textToRemove?.Remove();

// Save the document post-cleanup
doc.SaveAs("sample_cleaned.docx");
```

### Before Locate and Delete

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/remove-text/remove-text-find-before.webp" alt="Document before finding and removing text" class="img-responsive add-shadow">
    </div>
</div>

### After Locate and Delete

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/remove-text/remove-text-find-after.webp" alt="Document after finding and removing text" class="img-responsive add-shadow">
    </div>
</div