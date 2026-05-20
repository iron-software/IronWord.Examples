# IronWord.Examples

Runnable C# examples for [IronWord](https://ironsoftware.com/csharp/word/), a .NET library for creating, reading, and editing DOCX files without Microsoft Word or Office Interop.

## Install

```bash
dotnet add package IronWord
```

## Quickstart

```csharp
using IronWord;
using IronWord.Models;

// Create a new document with a styled paragraph
var doc = new WordDocument();

var paragraph = new Paragraph();
paragraph.AddTextRun(new TextRun("Hello, IronWord!"));
paragraph.AddTextRun(new TextRun(" Bold goes here.", new TextStyle { IsBold = true }));

doc.AddParagraph(paragraph);
doc.SaveAs("hello.docx");
```

To open an existing document instead, use `new WordDocument("existing.docx")`. Inserting images works similarly — construct an `Image` from a file or stream, set `Width` and `Height`, and add it to a paragraph with `paragraph.AddImage(image)`.

For production use, set a license key via `License.LicenseKey = "YOUR-KEY"`. Without one, documents include a watermark.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — focused snippets demonstrating individual features
- `get-started/` — minimal first projects covering installation and basic document creation
- `how-to/` — task-oriented guides for specific document operations
- `quickstart/` — end-to-end project scaffolds
- `tutorials/` — longer walkthroughs combining multiple features (including the `document-element` tutorial covering paragraphs, runs, images, shapes, and tables)

## Common tasks covered

- Creating and loading DOCX files
- Adding paragraphs, text runs, and styled text (font, size, color, bold, italic, underline, strikethrough)
- Inserting images and shapes with positioning and text wrap
- Building and editing tables: rows, columns, cell merging, borders, shading
- Page setup: paper size, orientation, margins, background color
- Bullet and numbered lists with custom indentation and nesting
- Find-and-replace and content extraction for data processing
- Saving to file, `MemoryStream`, or `byte[]` for HTTP delivery

## Platform support

.NET 10, 9, 8, 7, 6, 5, .NET Core 2x/3x, .NET Standard 2, and .NET Framework 4.6.2+. Windows, macOS, Linux, Docker, Azure, and AWS. See the [installation docs](https://ironsoftware.com/csharp/word/docs/) for environment-specific notes.

## Documentation and support

- Full documentation: [ironsoftware.com/csharp/word/docs](https://ironsoftware.com/csharp/word/docs/)
- API reference: [ironsoftware.com/csharp/word/object-reference/api](https://ironsoftware.com/csharp/word/object-reference/api/)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/). IronWord is a commercial library — see [licensing](https://ironsoftware.com/csharp/word/licensing/) for terms and trial details.