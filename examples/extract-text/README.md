***Based on <https://ironsoftware.com/examples/extract-text/>***

Extracting an extensive amount of text from documents can often be a tedious and lengthy process, particularly when faced with copious amounts of paragraphs and tables. Fortunately, the `ExtractText` method from IronWord offers a timely solution. This method allows developers to efficiently extract a defined amount of text from a document, removing the need for repetitive looping and facilitating easier access to the `Text` property. By using this method, developers can enhance their productivity and conserve valuable time.

Below, we demonstrate several effective strategies to utilize the `ExtractText` method, thereby increasing your productivity when extracting text from documents.

## Effective Techniques for Text Extraction from a Docx File

- `using IronWord;`
- `WordDocument doc = new WordDocument("multi-paragraph.docx");`
- `Console.WriteLine(doc.ExtractText());`
- `Console.WriteLine(doc.Paragraphs[0].ExtractText());`
- `Console.WriteLine(doc.Paragraphs.Last().ExtractText());`

## Text Extraction Process

Employing the IronWord library to extract text from a Word document is an uncomplicated process. First, the library is imported, then a `WordDocument` instance is created to load a document containing paragraphs. After this, the `ExtractText` method is invoked to output all the text contained in the document to the console.

### Extraction of Specific Text Segments

Although the previously described example extracts all text from the document, the IronWord library offers the capability to tailor the extraction process to specific sections or paragraphs. The `Paragraphs` property of the `WordDocument` presents an array of `Paragraphs`, which behaves like a generic list. This array can be manipulated based on your requirement, whether by accessing a specific index like `doc.Paragraphs[0]`, or by employing built-in methods for C# collections.

When referencing an index from the `Paragraphs`, it fetches and extracts text only from the document's initial paragraph, subsequently outputting it to the console. Similarly, the `Last` method is utilized on the `Paragraphs` array to extract and output only the text from the document’s concluding paragraph.

[Explore the IronWord API for Advanced Text Extraction](https://ironsoftware.com/csharp/word/object-reference/api/IronWord.html)