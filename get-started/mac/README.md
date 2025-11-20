# Setting Up IronWord on macOS

***Based on <https://ironsoftware.com/get-started/mac/>***


IronWord provides .NET developers with the capability to read, create, and edit Word documents in C# without the need for Microsoft Office. Although it is generally utilized on Windows and Linux, setting up IronWord on macOS is straightforward with proper configuration.

This tutorial will guide you through the steps to set up and get IronWord operating on your macOS development environment.

## Preliminary Steps for macOS

To begin using IronWord on macOS, ensure you have these essentials installed:

- [.NET 6 or .NET 7 SDK](https://dotnet.microsoft.com/en-us/download)
- [Homebrew](https://brew.sh) (the package manager for macOS)
- macOS 11 (Big Sur) or newer (compatible with both Apple Silicon and Intel processors)

IronWord is optimized for .NET Core LTS releases and newer versions of the .NET SDK.

## Installing Necessary macOS Libraries

IronWord relies on libgdiplus for graphical tasks like rendering and manipulating DOCX files.

Install libgdiplus using Homebrew with the following command:

```bash
brew install mono-libgdiplus
```

This command will install the essential native library for image rendering. If you encounter errors concerning System.Drawing.Common, it is likely due to the absence of this dependency.

## Adding the IronWord NuGet Package

IronWord is compatible with both Apple Silicon and Intel-based Macs. For most users, the standard IronWord package is recommended.

Install the package using this command:

```shell
Install-Package IronWord
```

## Ensuring Compatibility with macOS ARM Processors

IronWord fully supports macOS on Apple's Silicon chips. Developers using M1 or M2 processors should follow the same installation procedures and use the standard IronWord NuGet package.

When you are coding on platforms like Visual Studio for Mac or JetBrains Rider, make sure that you are targeting .NET 6 or later to achieve the best compatibility.