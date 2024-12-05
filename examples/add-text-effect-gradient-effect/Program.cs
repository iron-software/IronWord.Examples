using IronWord;
using IronWord.Models;

// Create new Word document
WordDocument doc = new WordDocument();

// Create and configure text style
TextStyle textStyle = new TextStyle();
textStyle.TextEffect = new TextEffect()
{
    GradientEffect = Gradient.DefaultGray,
};

// Add text with style
doc.AddText("Hello World").Style = textStyle;

// Export new Word document
doc.SaveAs("gradientEffect.docx");
