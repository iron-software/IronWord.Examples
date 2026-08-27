using IronWord.Models;
using IronWord;
namespace IronWord.Examples.HowTo.TextEffectShadowEffect
{
    public static class Section1
    {
        public static void Run()
        {
            new IronWord.WordDocument().AddText("Shadow!").Style = new IronWord.Models.TextStyle { TextEffect = new IronWord.Models.TextEffect { ShadowEffect = IronWord.Models.Shadow.OuterShadow1 } };
        }
    }
}