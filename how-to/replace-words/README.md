# How to Replace Text in a Word Document

***Based on <https://ironsoftware.com/how-to/replace-words/>***


In the realm of document automation, specifically altering text in Word documents, there's a frequent requirement for solutions that facilitate the modification of templates, the updating of reports, or the handling of bulk content. IronWord, a robust C# library, has been crafted to address these needs efficiently and effectively.

IronWord stands out by allowing direct manipulation of Word documents without the dependency on Microsoft Office Interop. This independence from having Word installed on your server not only accelerates the process but also enhances reliability and scalability, especially crucial for back-end operations and web applications.

This tutorial provides a practical walkthrough with code examples, showing how simple it is to search for and replace text within any Word document.

## Quickstart: Swift Text Replacement in Word Documents 

Here’s a brief tutorial to demonstrate how you can effortlessly modify text in a Word document using IronWord. With just a few lines of C# code, anyone can open a `.DOCX` file, alter specific text, and save the revised document. This streamlined method facilitates document automation in environments where Microsoft Office Interop is not an option, perfect for backend systems and web apps.

```csharp
// Simple Text Replacement Example
IronWord.Document doc = new IronWord.Document("sample.docx");
doc.ReplaceText("oldText", "newText");
doc.SaveAs("updated.docx");
```

## Example of Replacing Text

IronWord simplifies the process of text replacement in a Word Document. Initially, you load the document, then navigate to the `Paragraphs` collection to apply the `ReplaceText` method on the desired paragraph.

The `ReplaceText` method accepts two string arguments: the text to locate and the text to substitute. It is sensitive to case differences and changes every occurrence of the specified string within the chosen paragraph.

In IronWord, indexation starts from zero for all object lists.

### Input

In this example, we’ll work with this [sample Word document](https://ironsoftware.com/static-assets/word/how-to/replace-words/sample.docx) which consists of two paragraphs containing the text "old text".

<div style="text-align: center;">
   <img src="https://ironsoftware.com/static-assets/word/how-to/replace-words/sample-input.webp" alt="Sample Docx" style="max-width: 100%; box-shadow: 0px 2px 5px rgba(0,0,0,0.1);">
</div>

### Code

Below is a snippet demonstrating how to update the "old text" in the first paragraph to "new text".

```csharp
using IronWord;

// Open an existing Word document
WordDocument doc = new WordDocument("sample.docx");

// Amend the text in the first paragraph
doc.Paragraphs[0].ReplaceText("old text", "new text");

// Save the modified document
doc.SaveAs("updated.docx");
```

### Output

<div style="text-align: center;">
   <img src="https://ironsoftware.com/static-assets/word/how-to/replace-words/updated-output.webp" alt="Output Docx" style="max-width: 100%; box-shadow: 0px 2px 5px rgba(0,0,0,0.1);">
</div>

In the [modified document](https://ironsoftware.com/static-assets/word/how-to/replace-words/updated.docx), the first paragraph reflects the new text while the second is left unchanged.

## Replacing Multiple Text Instances

For changing every instance of a word throughout the document, iterate through the `Paragraphs` collection and apply the `ReplaceText` method to each.

We’ll utilize the same `sample.docx` file as before. If the search text isn't present in a paragraph, the loop skips that iteration.

### Code

This code snippet illustrates replacing "old text" with "new text" across all paragraphs.

```csharp
using IronWord;

// Access the Word document
WordDocument doc = new WordDocument("sample.docx");

// Iterate through paragraphs to update text
for (int i = 0; i < doc.Paragraphs.Count; i++)
{
    // Substitute "old text" with "new text" in each paragraph
    doc.Paragraphs[i].ReplaceText("old text", "new text");
}

// Save the revised document
doc.SaveAs("updated.docx");
```

### Output

<div style="text-align: center;">
   <img src="https://ironsoftware.com/static-assets/word/how-to/replace-words/updated-multiple-output.webp" alt="Output Multiple Docx" style="max-width: 100%; box-shadow: 0px 2px 5px rgba(0,0,0,0.1);">
</div>

The [final document](https://ironsoftware.com/static-assets/word/how-to/replace-words/updated.docx) displays that both paragraphs now contain "new text".

#### Finding Text

Before modifying text, validating its existence can be crucial. The `FindText` method searches through the document for the first occurrence of the specified text.

#### Code

```csharp
using IronWord;
using System;

// Load the Word document
WordDocument doc = new WordDocument("sample.docx");

// Search for the first occurrence of the specified text
Console.WriteLine(doc.FindText("old text"));
```

#### Output

<div style="text-align: center;">
   <img src="https://ironsoftware.com/static-assets/word/how-to/replace-words/find-text-output.webp" alt="Find Text Output" style="max-width: 100%; box-shadow: 0px 2px 5px rgba(0,0,0,0.1);">
</div>

This output confirms that the applicable text was found. If `FindText` returns null, it means the text doesn't exist in the document. Always double-check that your search term is correctly spelled and case-sensitive.