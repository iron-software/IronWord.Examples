using IronWord;
using System.Linq;
using System;

// Load docx
WordDocument doc = new WordDocument("multi-paragraph.docx");

// Returns text from the entire file
Console.WriteLine(doc.ExtractText());

// Returns text from the first paragraph only
Console.WriteLine(doc.Paragraphs[0].ExtractText());

// Returns text from the last paragraph only
Console.WriteLine(doc.Paragraphs.Last().ExtractText());
