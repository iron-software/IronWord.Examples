# Implementing License Keys in IronWord

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## Obtaining a License Key

Implementing a license key in IronWord removes any deployment restrictions and eliminates watermarks.

You can [purchase a license here](https://ironsoftware.com/csharp/word/licensing/) or sign up for a [free 30-day trial](https://ironsoftware.com/csharp/word/licensing/).

--------------------------------------------------------------------------------

## Step 1: Install the Most Recent Version of IronWord

## Step 2: Integrating Your License Key

### Implement your license with code

Incorporate this snippet at the beginning of your application before IronWord is utilized.

```csharp
IronWord.License.LicenseKey = "IRONWORD.MYLICENSE.KEY.1EF01";
```

--------------------------------------------------------------------------------

### Implement your license via Web.Config or App.Config

For a global application-wide key using Web.Config or App.Config, insert the following in your configuration under appSettings.

```xml
<configuration>
...
  <appSettings>
    <add key="IronWord.LicenseKey" value="IRONWORD.MYLICENSE.KEY.1EF01"/>
  </appSettings>
...
</configuration>
```

Be aware of a licensing problem with versions of IronWord released before [2024.3.5](https://www.nuget.org/packages/IronWord/2024.3.5) affecting:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

The `Web.config` file might not recognize the license key properly. For more information, refer to the [guide on Setting a License Key in Web.config](https://ironsoftware.com/csharp/word/troubleshooting/license-key-web.config/).

Check the `IronWord.License.IsLicensed` property and ensure it returns `true`.

--------------------------------------------------------------------------------

### Set your license key using a .NET Core appsettings.json file

To globally apply a key in .NET Core:

- Place appsettings.json at the root of your project
- Insert a 'IronWord.LicenseKey' entry in your JSON configuration file. Use your actual license key as the value.
- Set the property _Copy to Output Directory: Copy always_ for this file

Example _appsettings.json_:

```json
{
    "IronWord.LicenseKey":"IRONWORD.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Confirming the License Installation

To confirm the installation of the license key, utilize the code below to inspect the **IsLicensed** property:

```csharp
// Confirm if the license key was acknowledged
bool licensed = IronWord.License.IsLicensed;
```

### Check License Key Validity

To verify the validity of your license or trial key, use the following script:

```csharp
// Validate the license key
bool valid = IronWord.License.IsValidLicense("IRONWORD.MYLICENSE.KEY.1EF01");
```

If it returns **True**, your key is valid, and you're all set to use IronWord. If **False**, the key is invalid.

--------------------------------------------------------------------------------

## Step 4: Kick Off Your IronWord Project

To effectively start with IronWord, follow our detailed guide on [Getting Started with IronWord](https://ironsoftware.com/csharp/word/docs/), providing thorough instructions and examples for beginners.

--------------------------------------------------------------------------------

## Questions or Require Assistance?

For using IronWord on live projects, secure a paid or trial license key through [purchasing a license](https://ironsoftware.com/csharp/word/licensing/) or by [signing up for a trial](https://ironsoftware.com/csharp/word/licensing/).

Explore abundant resources including code examples, tutorials, licensing specifics, and exhaustive documentation in the [IronWord section](https://ironsoftware.com/csharp/word/) of our website.

For any inquiries, do not hesitate to contact <support@ironsoftware.com>.