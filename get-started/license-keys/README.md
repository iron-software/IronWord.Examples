# Implementing IronWord License Keys

***Based on <https://ironsoftware.com/get-started/license-keys/>***


## Acquiring a License Key

To remove watermarks and deployment restrictions in your projects, obtaining an IronWord license key is essential.

You can [purchase a license key here](https://ironsoftware.com/csharp/word/licensing/) or [register for a free 30-day trial key](https://ironsoftware.com/trial-license).

---

## Step 1: Download the Current Version of IronWord

---

## Step 2: Activate Your License Key

### Activate via Code

Insert the following code at the beginning of your application to set up your license before using IronWord.

```csharp
IronWord.License.LicenseKey = "IRONWORD.MYLICENSE.KEY.1EF01";
```

---

### Activate via Web.Config or App.Config

For a global application-wide license configuration, add the following entry in your configuration file within the `appSettings` section.

```xml
<configuration>
  <appSettings>
    <add key="IronWord.LicenseKey" value="IRONWORD.MYLICENSE.KEY.1EF01"/>
  </appSettings>
</configuration>
```

Be aware of a licensing issue with IronWord releases prior to [version 2024.3.5](https://www.nuget.org/packages/IronWord/2024.3.5) specific to:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

Licenses specified in `Web.config` may not be recognized. For troubleshooting, refer to our [Web.config Licensing Issues guide](https://ironsoftware.com/csharp/word/troubleshooting/license-key-web.config/).

Confirm licensing with `IronWord.License.IsLicensed` to ensure it returns `true`.

---

### Activate via a .NET Core appsettings.json file

Globally apply your license in a .NET Core application by:

- Creating an `appsettings.json` file in your project's root directory.
- Adding an `IronWord.LicenseKey` with your license key.
- Setting the file property _Copy to Output Directory: Copy always_.

Contents of _appsettings.json_:

```json
{
    "IronWord.LicenseKey": "IRONWORD.MYLICENSE.KEY.1EF01"
}
```

---

## Step 3: Confirm Your License Key

### Confirm License Installation

Check the **IsLicensed** property to verify your license implementation:

```csharp
// Determine if IronWord is licensed
bool licensed = IronWord.License.IsLicensed;
```

### Ensure License Key Validity

Validate your license or trial key using this code:

```csharp
// Check the validity of the license key
bool valid = IronWord.License.IsValidLicense("IRONWORD.MYLICENSE.KEY.1EF01");
```

A return value of **True** indicates a valid key, ready for use with IronWord. A **False** return suggests the key may be invalid.

---

## Step 4: Starting Your Project with IronWord

Kick off your project by following our detailed [IronWord Getting Started Guide](https://ironsoftware.com/csharp/word/docs/).

---

## Support and Further Assistance

Obtaining a license for commercial usage requires either a purchase or a trial registration, which you can address [here](https://ironsoftware.com/csharp/word/licensing/) and [here](https://ironsoftware.com/trial-license), respectively.

Explore a variety of coding examples, detailed tutorials, and comprehensive docs in our [IronWord specific section](https://ironsoftware.com/csharp/word/).

For queries, contact us directly at <support@ironsoftware.com>.