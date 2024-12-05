***Based on <https://ironsoftware.com/examples/add-list/>***

This example demonstrates the process of creating a multi-level list in a structured Word document using the IronWord library in C#.

Begin by initiating a new Word document through the `WordDocument` class. This document consists of a text run containing the words "sample text," which is enclosed within a paragraph. This paragraph is then turned into a `ListItem`. Next, a `MultiLevelTextList` is created, and the previously mentioned `ListItem` is appended to it four times for repetition. To conclude, this `MultiLevelTextList` is incorporated into the Word document. The final step is to save the entire document as a DOCX file under the name "document.docx."