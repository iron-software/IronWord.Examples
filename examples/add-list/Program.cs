using IronWord;
using IronWord.Models;

// Create Word doc
WordDocument doc = new WordDocument();

// Create textrun
Text textRun = new Text();
textRun.Text = "sample text";

// Create paragraph
Paragraph paragraph = new Paragraph();
paragraph.AddText(textRun);

// Create list
ListItem listItem = new ListItem(paragraph);

// Create text list
MultiLevelTextList textList = new MultiLevelTextList();
textList.AddItem(listItem);
textList.AddItem(listItem);
textList.AddItem(listItem);
textList.AddItem(listItem);

// Add text list
doc.AddMultiLevelTextList(textList);

// Export docx
doc.SaveAs("document.docx");
