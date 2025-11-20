using IronWord;
namespace IronWord.Examples.HowTo.TextEffectGradientEffect
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Apply Gradient Text Easily
            var doc = new IronWord.WordDocument();
            doc.AddText("Test").Style = new IronWord.Models.TextStyle(){ TextEffect = new IronWord.Models.TextEffect(){ GradientEffect = IronWord.Models.Gradient.DefaultGray } };
            doc.SaveAs("out.docx");
        }
    }
}