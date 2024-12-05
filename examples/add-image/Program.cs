using IronWord;
using IronWord.Models;

// Load docx
WordDocument doc = new WordDocument();

// Configure image
IronWord.Models.Image image = new IronWord.Models.Image("salvatore-tonnara.jpg");
image.Width = 200; // In unit pixel
image.Height = 200; // In unit pixel
Paragraph paragraph = new Paragraph();

// Add image
paragraph.AddImage(image);

// Add paragraph
doc.AddParagraph(paragraph);

// Export docx
doc.SaveAs("save_document.docx");
