***Based on <https://ironsoftware.com/examples/add-list/>***

This guide demonstrates how to efficiently create a well-organized Word document featuring a multi-level list using the IronWord library in C#.

Start by creating a new Word document using the `WordDocument` class. The document structure begins with a text run containing the phrase "sample text," which is enclosed within a paragraph. This paragraph is then transformed into a `ListItem`. Following this, a `MultiLevelTextList` is created, and the previously mentioned `ListItem` is appended to it four times. To finalize, this `MultiLevelTextList` is incorporated into the Word document. The document is then saved as a DOCX file under the name "document.docx."