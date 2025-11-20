# Implementing IronWord for .NET on Windows Platforms

***Based on <https://ironsoftware.com/get-started/windows/>***


IronWord is fully compatible with Windows 10, Windows 11, and Windows Server 2016 or later versions. It seamlessly integrates with various .NET platforms including .NET 10, 9, 8, 7, 6, .NET Core, .NET Standard 2.0+, and .NET Framework 4.6.2 and higher.

One of the key advantages of IronWord is that it does not depend on graphical frameworks like `System.Drawing`. This attribute makes it ideal for non-GUI server environments. Thus, IronWord excels in Windows Server Core setups where traditional graphical libraries might not be available.

Important: Deploying on Windows Server Core requires that all necessary .NET runtimes and other operating system dependencies are in place. Although IronWord doesn’t need graphics support, some complex operations might depend on certain system libraries that should be enabled or installed if they aren't present by default.

## Specific Installation Steps for Windows

### Install via NuGet

The `IronWord` package is accessible via NuGet and supports both x86 and x64 architectures.

The package is designed to work with .NET Framework version 4.6.2 and newer, including .NET Core and Standard versions up to .NET 10. 

Optimizations for minimal deployment involve removing any non-required architecture-specific directories from the `/runtimes` subdirectory of your project.

To install the package, use the following command in the Package Manager Console:

```shell
Install-Package IronWord
```