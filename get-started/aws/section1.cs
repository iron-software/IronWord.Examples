using System;
using System.IO;
using IronWord;
namespace IronWord.Examples.GettingStarted.Aws
{
    public static class Section1
    {
        public static void Run()
        {
            // AWS Lambda's filesystem is read-only apart from /tmp/, so any
            // document the function writes locally before uploading to S3 has
            // to go there. IronWord reads from anywhere; only writes are
            // constrained, so no library configuration is needed - just build
            // the output path under /tmp/.
            var awsTmpPath = @"/tmp/";
            License.LicenseKey = "YOUR-LICENSE-KEY";

            var localFilePath = Path.Combine(awsTmpPath, Guid.NewGuid() + ".docx");
            Console.WriteLine($"Documents will be written to {localFilePath}");
        }
    }
}
