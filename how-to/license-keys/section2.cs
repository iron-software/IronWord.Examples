using IronWord;
namespace IronWord.Examples.HowTo.LicenseKeys
{
    public static class Section2
    {
        public static void Run()
        {
            // Check if the license key has been applied
            bool licensed = IronWord.License.IsLicensed;
        }
    }
}