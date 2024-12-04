using IronWord;
namespace ironword.LicenseKeys
{
    public class Section2
    {
        public void Run()
        {
            // Check if the license key has been applied
            bool licensed = IronWord.License.IsLicensed;
        }
    }
}