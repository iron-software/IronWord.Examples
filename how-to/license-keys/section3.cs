using IronWord;
namespace ironword.LicenseKeys
{
    public class Section3
    {
        public void Run()
        {
            // Check if a given license key string is valid
            bool valid = IronWord.License.IsValidLicense("IRONWORD.MYLICENSE.KEY.1EF01");
        }
    }
}