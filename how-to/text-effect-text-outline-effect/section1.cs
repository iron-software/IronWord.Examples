using IronWord.Models;
using IronWord;
namespace IronWord.Examples.HowTo.TextEffectTextOutlineEffect
{
    public static class Section1
    {
        public static void Run()
        {
            new IronWord.Models.TextStyle { TextEffect = new IronWord.Models.TextEffect { TextOutlineEffect = IronWord.Models.TextOutlineEffect.DefaultEffect } }
        }
    }
}