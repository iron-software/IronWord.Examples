using IronWord;
namespace IronWord.Examples.HowTo.TextEffectGlowEffect
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Glow Text in Seconds
            someTextElement.Style.TextEffect = new IronWord.Models.TextEffect { GlowEffect = new IronWord.Models.Glow { GlowRadius = 8, GlowColor = System.Drawing.Color.FromArgb(180, 0, 128, 255) } };
        }
    }
}