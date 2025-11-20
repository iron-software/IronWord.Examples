# Harnessing IronWord for iOS Development

***Based on <https://ironsoftware.com/get-started/ios/>***


Developing native applications across multiple platforms like Android, iOS, Windows, and macOS is streamlined through .NET MAUI (Multi-platform App UI), which leverages a unified .NET codebase. Utilizing IronWord enhances .NET developers' capabilities to seamlessly create, read, manipulate, and store Microsoft Word (.docx) documents. This functionality is fully supported across all platforms without the need for Microsoft Office, making IronWord a universally applicable solution.

IronWord integrates seamlessly into iOS as part of the .NET MAUI shared codebase. Its implementation requires only the standard IronWord NuGet package, eliminating the need for any platform-specific variations.

## Implementing the IronWord NuGet Package

IronWord is readily accessible as a versatile cross-platform NuGet package, ensuring compatibility with all principal .NET MAUI platforms, including iOS.

```shell
Install-Package IronWord
```

## Starting a .NET MAUI Project

To initiate a project in Visual Studio:

1. Navigate to File > New > Project.
2. Select .NET MAUI App under the Multiplatform section.
3. Assign a name to your project, such as `IronWordMauiIOS`, and proceed by clicking Create.

### Integrating IronWord into Your Project

Incorporate IronWord by utilizing NuGet Package Manager or by directly updating your .csproj file:

```xml
<ItemGroup>
  <PackageReference Include="IronWord" Version="2025.5.0" />
</ItemGroup>
```

IronWord is designed to function universally across all platforms without the need for specific platform targeting.

### Designing the App Interface with XAML

Create a user interface to facilitate document loading, editing, and saving by adding the following code to your `MainPage.xml`:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="IronWordMauiIOS.MainPage"
             BackgroundColor="White">

    <VerticalStackLayout Padding="20"
                         Spacing="15"
                         VerticalOptions="Center">

        <Label Text="IronWord iOS Demo"
               FontSize="24"
               FontAttributes="Bold"
               HorizontalOptions="Center"
               TextColor="#222"/>

        <Button Text=" Open Word Document"
                Clicked="OpenDocx"
                BackgroundColor="#007AFF"
                TextColor="White"
                CornerRadius="10"
                HeightRequest="50"/>

        <Editor x:Name="docEditor"
                Placeholder="Start editing..."
                AutoSize="TextChanges"
                HeightRequest="250"
                FontSize="16"
                TextColor="#333"
                BackgroundColor="#F9F9F9"
                CornerRadius="10"
                Margin="0,10,0,0"/>

        <Button Text=" Save as .docx"
                Clicked="SaveDocx"
                BackgroundColor="#34C759"
                TextColor="White"
                CornerRadius="10"
                HeightRequest="50"/>

        <Label x:Name="statusLabel"
               FontSize="14"
               TextColor="Gray"
               HorizontalOptions="Center"/>
    </VerticalStackLayout>
</ContentPage>
```

This setup includes buttons and an editor for managing Word documents efficiently.

### Deploying IronWord in the Shared Codebase

In your `MainPage.xaml.cs`, you'll manage DOCX files as follows:

```cs
using IronWord;
using IronWord.Models;
using Microsoft.Maui.Storage;
using System.Text;

namespace IronWordMauiIOS;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        License.LicenseKey = "YOUR-LICENSE-KEY"; // Set your IronWord license
    }

    private async void OpenDocx(object sender, EventArgs e)
    {
        var file = await FilePicker.PickAsync();
        if (file == null) return;

        var path = Path.Combine(FileSystem.CacheDirectory, file.FileName);
        using (var source = await file.OpenReadAsync())
        using (var target = File.Create(path))
            await source.CopyToAsync(target);

        var doc = new WordDocument(path);
        docEditor.Text = ExtractText(doc);
        statusLabel.Text = "Document loaded successfully.";
    }

    private async void SaveDocx(object sender, EventArgs e)
    {
        var document = new WordDocument();
        var paragraph = new Paragraph();
        paragraph.Texts.Add(new TextContent(docEditor.Text));
        document.Paragraphs.Add(paragraph);

        var fileName = $"ExportedDoc_{DateTime.Now:yyyyMMddHHmmss}.docx";
        var path = Path.Combine(FileSystem.AppDataDirectory, fileName);
        document.SaveAs(path);

        statusLabel.Text = $"Saved to: {fileName}";
    }

    private string ExtractText(WordDocument doc)
    {
        var sb = new StringBuilder();
        foreach (var para in doc.Paragraphs)
        {
            foreach (var element in para.Texts)
            {
                if (element is TextContent text)
                    sb.AppendLine(text.Text);
            }
        }
        return sb.ToString();
    }
}
```

### Overview of Project Structure

Your project directory should now appear as follows:

```
IronWordMauiIOS/
│
├── MainPage.xaml              ← Layout interface
├── MainPage.xaml.cs           ← Logic behind UI operations for Word documents
├── IronWordMauiIOS.csproj     ← Includes IronWord package reference
├── Platforms/ios/              ← iOS-specific configurations (unaltered)
└── ...
```

### Executing the Project

1. Select the iOS Simulator as your target.
2. Hit the Run button.
3. Begin testing the read and write functions for .docx files on the iOS emulator.

## Key Takeaways

- Applicable across all major platforms (iOS, Android, Windows, macOS)
- No dependency on Microsoft Office or similar
- Fully native to C# / .NET MAUI
- Operational offline
- Ideal for developing document-based applications like editors and viewers.