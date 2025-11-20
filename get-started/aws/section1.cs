using IronWord;
namespace IronWord.Examples.GettingStarted.Aws
{
    public static class Section1
    {
        public static void Run()
        {
            var awsTmpPath = @"/tmp/";
            IronSoftware.Word.Installation.DeploymentPath = awsTmpPath;
        }
    }
}