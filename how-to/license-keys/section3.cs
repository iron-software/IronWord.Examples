using IronWord;
namespace IronWord.Examples.HowTo.LicenseKeys
{
    public static class Section3
    {
        public static void Run()
        {
            // Check if a given license key string is valid
            bool valid = IronWord.License.IsValidLicense("IRONWORD.MYLICENSE.KEY.1EF01");
        }
    }
}