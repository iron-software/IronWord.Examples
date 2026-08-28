using System;
using IronWord;
namespace IronWord.Examples.GettingStarted.Aws
{
    public static class Section1
    {
        public static void Run()
        {
            var awsTmpPath = @"/tmp/";
            // The guide sets IronSoftware.Word.Installation.DeploymentPath here.
            // No Installation type ships in IronWord 2026.8, so the closest
            // supported equivalent is to point the process at the writable
            // directory before any document work begins.
            Environment.SetEnvironmentVariable("TMPDIR", awsTmpPath);
            License.LicenseKey = "YOUR-LICENSE-KEY";
        }
    }
}