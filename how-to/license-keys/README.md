# Using IronWord License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## How to Acquire a License Key

Enabling an IronWord license key ensures that when your application is live, there are no usage restrictions or watermarks.

To obtain a license, you can [purchase one here](https://ironsoftware.com/csharp/word/licensing/) or you can register for a [free 30 day trial key here](https://ironsoftware.com/csharp/word/trial-license).

--------------------------------------------------------------------------------

## Step 1: Download the Latest Version of IronWord

<!-- Missing content placeholder -->

## Step 2: Implement Your License Key

### Embed your license in your code

Insert this code at the beginning of your application before utilizing IronWord.

```csharp
using IronWord;
namespace ironword.LicenseKeys
{
    public class SetupLicense
    {
        public void Apply()
        {
            IronWord.License.LicenseKey = "IRONWORD.MYLICENSE.KEY.1EF01";
        }
    }
}
```

--------------------------------------------------------------------------------

### Apply your license through Web.Config or App.Config

To set the license key for your entire application via Web.Config or App.Config, include this entry in your config file under appSettings.

```xml
<configuration>
...
  <appSettings>
    <add key="IronWord.LicenseKey" value="IRONWORD.MYLICENSE.KEY.1EF01"/>
  </appSettings>
...
</configuration>
```

Be aware of a licensing complication with versions of IronWord released prior to [2024.3.5](https://www.nuget.org/packages/IronWord/2024.3.5) in:
- **ASP.NET** projects
- **.NET Framework versions 4.6.2 and above**

In such cases, the `Web.config` does not successfully integrate the license key. For solutions, visit the ['How to Set License Key in Web.config'](https://ironsoftware.com/csharp/word/troubleshooting/license-key-web.config/) guide.

Make sure that `IronWord.License.IsLicensed` yields `true` to confirm.

--------------------------------------------------------------------------------

### Incorporate your license key via a .NET Core appsettings.json file

To apply the key across your .NET Core application:

- Create a JSON configuration file named `appsettings.json` at the root of your project
- Include an 'IronWord.LicenseKey' in your JSON configuration. Assign it your license code.
- Set the file properties to _Copy to Output Directory: Copy always_

File: _appsettings.json_

```json
{
    "IronWord.LicenseKey": "IRONWORD.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Check the Activated License Key

To determine if the license has been correctly installed, examine the **IsLicensed** attribute with this code:

```csharp
using IronWord;
namespace ironword.LicenseKeys
{
    public class VerifyLicense
    {
        public void Check()
        {
            // Verifies the application of the license key
            bool licensed = IronWord.License.IsLicensed;
        }
    }
}
```

### Verify the License Key

To test the validity of your license or trial key, employ this piece of code:

```csharp
using IronWord;
namespace ironword.LicenseKeys
{
    public class ValidateLicense
    {
        public void Test()
        {
            // Determines the validity of the specified license key
            bool valid = IronWord.License.IsValidLicense("IRONWORD.MYLICENSE.KEY.1EF01");
        }
    }
}
```

If the method returns **True**, your key is valid and you can proceed with utilizing IronWord. A **False** result signifies an invalid key.

--------------------------------------------------------------------------------

## Step 4: Initiating Your Project

To begin working with IronWord, we suggest looking through our extensive [Getting Started with IronWord](https://ironsoftware.com/csharp/word/docs/) guide, providing comprehensive instructions and practical examples.

--------------------------------------------------------------------------------

## Questions or Require Assistance?

For deploying IronWord in production environments, a paid or trial license key is essential, available through [purchasing a license](https://ironsoftware.com/csharp/word/licensing/) or by [accessing the trial license here](https://ironsoftware.com/csharp/word/trial-license).

Explore our [IronWord section](https://ironsoftware.com/csharp/word/) for a plethora of code samples, educational resources, licensing information, and thorough documentation.

For further inquiries, please contact <support@ironsoftware.com>.