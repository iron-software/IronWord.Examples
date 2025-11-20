***Based on <https://ironsoftware.com/examples/add-style-text/>***

The "Add Style Text" capability in IronWord provides developers the tools to include a variety of text styles when integrating content into a DOCX file. This function allows precise customization of text attributes, including font type, size, color, and styles such as bold, italic, underline, and strike-through. Developers can configure a `Text` object's `TextStyle`, enabling them to define the visual elements of text sections on a granular level and ensure the document maintains a polished and tailored appearance.

This utility is particularly beneficial for the automatic generation of professionally formatted documents, like reports or missives, where distinguishing styles in certain sections is crucial. The `TextStyle` class offers straightforward options for editing these styles, facilitating the design process for both straightforward and intricate document formats.

## 5 Steps to Add Styled Text to a DOCX

The following code sample demonstrates the procedure for adding and styling text in a DOCX file utilizing IronWord. The process commences with the creation of a new `WordDocument` instance, which acts as the scaffold for the document to be crafted. A `Text` object is initiated with the phrase "`Styled text example`," along with a `TextStyle` that is set up to define the text’s visual aspects. The styling settings such as the chosen font `Arial`, a font size of `14`, the color `blue`, and the application of `bold` attribute are all set to tailor how the text will display in the final document.

Once the text has been appropriately styled, it is added to the document using the `AddText` method. This function integrates the configured text into the DOCX format. To finalize the process, the `SaveAs` method is utilized, exporting the document as "`styled_document.docx`". As a result, the Word document will contain the text with the designated styles, ensuring all typography and formatting characteristics are retained in the exported file.

[Explore Document Element Tutorials for More Styling Tips](https://ironsoftware.com/csharp/word/tutorials/document-element/)