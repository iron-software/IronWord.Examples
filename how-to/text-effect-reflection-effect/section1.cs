using IronWord;
namespace IronWord.Examples.HowTo.TextEffectReflectionEffect
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Try Reflection Effect Now
            new IronWord.WordDocument().AddText("Quick Text").Style = new IronWord.Models.TextStyle(){ TextEffect = new IronWord.Models.TextEffect(){ ReflectionEffect = new IronWord.Models.Reflection() } };
        }
    }
}