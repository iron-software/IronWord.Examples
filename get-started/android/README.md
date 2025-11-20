# Reading and Writing Word Documents on Android with .NET MAUI

***Based on <https://ironsoftware.com/get-started/android/>***


.NET MAUI (Multi-platform App UI) provides a framework for developers to create native applications for Android, iOS, macOS, and Windows using a single C# codebase. This unified approach not only streamlines the development process but also ensures native performance across all platforms.

IronWord, while not having a specific Android-only package, operates effectively on Android through the .NET MAUI framework. This integration allows developers to easily implement functionality for reading and writing Word documents on Android devices.

## Step 1: Set up your .NET MAUI Application Project

To start, launch Visual Studio and initiate a new .NET MAUI App project, which is designed to facilitate multi-platform app development from a singular codebase.

Name your project something descriptive, such as IronWordMauiAndroid, to maintain clarity. This initial step is crucial as it prepares you to create a native Android application with little to no need for platform-specific coding.

## Step 2: Integrate the IronWord NuGet Package

Incorporating IronWord into your .NET projects is simplified through its NuGet package. To integrate IronWord, right-click on your project, select Manage NuGet Packages, then find and install the latest stable version of "IronWord."

For a quicker installation, you can utilize the NuGet Package Manager Console with the following command:

```shell
Install-Package IronWord
```

## Step 3: Design the User Interface in MainPage.xaml

Create a user-friendly interface in XAML for users to generate and save Word documents on Android devices. The interface should include:

- An editable multi-line text editor for user input.
- A button labeled "Save as Word Document" that, when clicked, saves the input text as a .docx file.
- A status label that displays messages or errors to the user.

Below is the XAML markup for setting up the interface:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="IronWordAndroid.MainPage">

    <VerticalStackLayout Padding="20" Spacing="15">
        <Editor x:Name="WordEditor" Placeholder="Enter your text..."
                AutoSize="TextChanges" HeightRequest="300"/>
        <Button Text="Save as Word Document" Clicked="OnSaveWordClicked"/>
        <Label x:Name="StatusLabel" FontSize="12" TextColor="Gray"/>
    </VerticalStackLayout>
</ContentPage>
```

## Step 4: Implement Document Handling in MainPage.xaml.cs

With your UI ready, it's time to add the functionality to save documents. In MainPage.xaml.cs, enter your IronWord license key in the constructor and code the `OnSaveWordClicked` method.

This method creates a new `WordDocument`, populates it with text from the Editor, and saves the document. On Android, the file is saved to the Downloads folder, whereas other platforms use the app’s cache directory.

To handle errors, implement a try-catch block that catches exceptions and displays them in the status label.

The complete code is as follows:

```cs
using IronWord;
using IronWord.Models;
using Microsoft.Maui.Storage;
using System;

namespace IronWordAndroid;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        License.LicenseKey = "YOUR-LICENSE-KEY";
    }

    private async void OnSaveWordClicked(object sender, EventArgs e)
    {
        try
        {
            var document = new WordDocument();
            var paragraph = new Paragraph(new TextContent(WordEditor.Text));
            document.AddParagraph(paragraph);

            string fileName = $"MyWordDoc_{DateTime.Now:yyyyMMddHHmmss}.docx";

#if ANDROID
            string filePath = Path.Combine("/storage/emulated/0/Download", fileName);
#else
            string filePath = Path.Combine(FileSystem.CacheDirectory, fileName);
#endif

            document.SaveAs(filePath);

            StatusLabel.Text = $"Saved to: {filePath}";
            await DisplayAlert("Success", $"File saved: {filePath}", "OK");
        }
        catch (Exception ex)
        {
            StatusLabel.Text = $"Error: {ex.Message}";
        }
    }
}
```

## Step 5: Test Your Application on Android

Deploy your application directly to an Android emulator or a physical device via Visual Studio to promptly evaluate its functionality, such as the ability to open, edit, and save Word documents.

The integration of the native Android file picker enhances user experience by providing a familiar interaction pattern.

Thanks to IronWord's full compatibility within the .NET environment, no additional SDKs or platform-specific adjustments are necessary, simplifying the development, maintenance, and distribution of your application.