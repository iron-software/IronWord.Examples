# Utilizing IronWord License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## Obtaining a License Key

To deploy your application live without facing any restrictions or watermarks, it's essential to add an IronWord license key.

You can [purchase a license here](https://ironsoftware.com/csharp/word/licensing/) or opt for a [free 30-day trial key](https://ironsoftware.com/csharp/word/trial-license).

--------------------------------------------------------------------------------

## Step 1: Acquire the Latest IronWord Edition

## Step 2: Implement Your License Key

### Integrate your license via code

Incorporate this code at the beginning of your application to ensure IronWord is licensed before use.

```csharp
using IronWord;
namespace ironword.LicenseKeys
{
    public class ActivateLicense
    {
        public void Execute()
        {
            IronWord.License.LicenseKey = "IRONWORD.MYLICENSE.KEY.1EF01";
        }
    }
}
```

--------------------------------------------------------------------------------

### Integrate your license via Web.Config or App.Config

For a broad application of your license key using Web.Config or App.Config, include the following entry in your config file under appSettings.

```xml
<configuration>
...
  <appSettings>
    <add key="IronWord.LicenseKey" value="IRONWORD.MYLICENSE.KEY.1EF01"/>
  </appSettings>
...
</configuration>
```

Please be aware of a licensing issue for IronWord version prior to [2024.3.5](https://www.nuget.org/packages/IronWord/2024.3.5) in the following scenarios:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

The `Web.config` file does not consistently enforce the license key. Learn more in the ['Setting License Key in Web.config'](https://ironsoftware.com/csharp/word/troubleshooting/license-key-web.config) article.

Double-check that `IronWord.License.IsLicensed` evaluates to `true`.

--------------------------------------------------------------------------------

### Embed your license key using a .NET Core appsettings.json file

To broadly apply your key in a .NET Core environment:

- Place a JSON file named `appsettings.json` in your project's root directory.
- Insert a key named 'IronWord.LicenseKey' in your JSON configuration file with the license key as its value.
- Set the file property to _Copy to Output Directory: Copy always_.

File: _appsettings.json_

```json
{
    "IronWord.LicenseKey":"IRONWORD.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Inspect the Installed License Key

To confirm the license key's correct application, verify the `IsLicensed` property using this code snippet:

```csharp
using IronWord;
namespace ironword.LicenseKeys
{
    public class ValidateLicense
    {
        public void Execute()
        {
            // Inspecting if the license key is correctly applied
            bool licensed = IronWord.License.IsLicensed;
        }
    }
}
```

### Ascertain the License Key’s Validity

To verify your license or trial key's authenticity, deploy this code snippet:

```csharp
using IronWord;
namespace ironword.LicenseKeys
{
    public class CheckLicenseValidity
    {
        public void Execute()
        {
            // Validate the actual license key string
            bool valid = IronWord.License.IsValidLicense("IRONWORD.MYLICENSE.KEY.1EF01");
        }
    }
}
```

A return value of **True** indicates you've successfully validated the key and can commence using IronWord. A value of **False** signifies an issue with your key.

--------------------------------------------------------------------------------

## Step 4: Engage with Your Project

To initiate your journey with IronWord, we strongly suggest our detailed tutorial on how to [Get Started with IronWord](https://ironsoftware.com/csharp/word/docs/). This guide provides thorough instructions and examples for mastering IronWord basics.

--------------------------------------------------------------------------------

## Queries or Require Assistance?

If you are planning to use IronWord in live projects, secure a paid or trial license by [purchasing a license](https://ironsoftware.com/csharp/word/licensing/) or by visiting [this link](https://ironsoftware.com/csharp/word/trial-license).

For an extensive set of code examples, tutorials, licensing information, and comprehensive documentation, head to the [IronWord section](https://ironsoftware.com/csharp/word/) on our website.

For any inquiries, don't hesitate to contact <support@ironsoftware.com>.