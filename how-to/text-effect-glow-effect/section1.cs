using IronWord.Models;
using IronWord;
namespace IronWord.Examples.HowTo.TextEffectGlowEffect
{
    public static class Section1
    {
        public static void Run()
        {
            TextContent someTextElement = new TextContent("Glowing text");
            someTextElement.Style = new TextStyle();
            someTextElement.Style.TextEffect = new IronWord.Models.TextEffect { GlowEffect = new IronWord.Models.Glow { GlowRadius = 8, GlowColor = new IronWord.Models.Color(180, 0, 128, 255) } };
        }
    }
}