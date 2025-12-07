# Extract Text from DOCX with C# using IronWord

***Based on <https://ironsoftware.com/how-to/extract-text/>***


Retrieving text from DOCX documents is a crucial task in document management and data extraction. IronWord simplifies this process by allowing developers to easily extract text from DOCX files, including paragraphs, tables, and other elements with programmatic ease.

This guide showcases the use of the `ExtractText()` method, highlighting its effectiveness in pulling data from various components of a document.

<h3>Getting Started with IronWord</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Text Extraction Example

Here, we demonstrate how to utilize the `ExtractText()` method to access text from an entire Word document. We begin by creating a new document object, adding some sample text, executing `ExtractText()`, and then displaying the output in the console.

```csharp
using IronWord;

// Create a new instance of a DOCX file
WordDocument doc = new WordDocument();

// Add some text
doc.AddText("Hello, World!");

// Output the extracted text to the console
Console.WriteLine(doc.ExtractText());
```

### Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-simple.webp" alt="Code example for basic text extraction" class="img-responsive add-shadow">
    </div>
</div>

### Console Log

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-simple-console.webp" alt="Console output showing extracted text" class="img-responsive add-shadow">
    </div>
</div>

## Extract Text from a Paragraph

Gain more detailed control by extracting text from specific paragraphs. This is done by accessing the `Paragraphs` collection to manipulate specific sections of your document. Below is an example where text from the first and last paragraphs is extracted, combined, and then saved as a new `.txt` file.

```csharp
using IronWord;
using System.IO;

// Open an existing DOCX file
WordDocument doc = new WordDocument("document.docx");

// Extract text and assign to variables
string firstParagraph = doc.Paragraphs[0].ExtractText();
string lastParagraph = doc.Paragraphs.Last().ExtractText();

// Concatenate the extracted texts
string combinedText = firstParagraph + " " + lastParagraph;

// Save the new combined text to a .txt file
File.WriteAllText("output.txt", combinedText);
```

### First Paragraph

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-first-paragraph.webp" alt="First paragraph extraction result" class="img-responsive add-shadow">
    </div>
</div>

### Last Paragraph

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-last-paragraph.webp" alt="Last paragraph extraction result" class="img-responsive add-shadow">
    </div>
</div>

### Text Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-text-output.webp" alt="Combined text output in text file" class="img-responsive add-shadow">
    </div>
</div>

The images above illustrate the extraction results from the first and last paragraphs, as well as the combined text saved in a text file.

## Text Extraction from a Table

Extracting data from tables is essential for accessing structured information. With IronWord, you can navigate through table rows and cells to retrieve precise data. In this example, we load a document holding an API statistics table and isolate a specific cell's data from the 4th column of the 2nd row.

```csharp
using IronWord;

// Load a document containing API statistics
WordDocument apiStatsDoc = new WordDocument("api-statistics.docx");

// Retrieve text from the desired table cell
string extractedValue = apiStatsDoc.Tables[0].Rows[2].Cells[3].ExtractText();

// Display the value on the console
Console.WriteLine($"Target success rate: {extractedValue}");
```

### Example Table

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-table.webp" alt="API statistics table in Word document" class="img-responsive add-shadow">
    </div>
</div>

### Console Log

<div class="content-img-align-center">
    <div the="center-image-wrapper">
         <img src="https://ironsoftware.com/static-assets/word/how-to/extract-text/extract-text-table-console.webp" alt="Extracted table cell value in console" class="img-responsive add-shadow">
    </div>
</div>