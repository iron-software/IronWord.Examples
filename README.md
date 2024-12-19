![Nuget Version](https://img.shields.io/nuget/v/IronWord?color=informational&label=latest) ![Installs](https://img.shields.io/nuget/dt/IronWord?color=informational&label=installs&logo=nuget) ![Build Status](https://img.shields.io/badge/build-%20%E2%9C%93%20522%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio) ![Windows Support](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows) ![macOS Support](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple) ![Linux Support](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white) ![Docker Support](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white) ![AWS Compatibility](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws) ![Microsoft Azure Compatibility](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure) [![Live Chat](https://img.shields.io/badge/Live%20Chat:-24/5-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## IronWord - Your C# Word Processing Library

[![IronWord NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronWord-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

IronWord is a robust tool developed by Iron Software that enhances C# developers' capabilities in creating, editing, and storing Word documents within .NET frameworks and websites.

#### Outstanding Features of IronWord:

  * Comprehensive management of Word and DOCX files.
  * PageSetup: Setting up page sizes, orientations, margins, and background colors.
  * TextRun: Manipulating text by edging, fine-tuning styles, appending images, and more.
  * TextStyle: Managing font type, size, colors, and text attributes like bold, italic, underline, etc.
  * Paragraph: Assembling text runs, imagery, alignments, and sessioning lists and bullets.
  * Table: Robust table constructions, with capabilities to add, modify, or merge table elements.
  * Image: Integrating images with customization of dimensions and text wrapping.
  * Shape: Inserting different shapes with adjustable text wrap, size, and rotation.

Explore these and more on [our features page](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) and see our [extensive code library](https://ironsoftware.com/csharp/word/examples/add-text/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist).

#### Cross-Platform Support From IronWord:

IronWord supports a variety of environments and frameworks:
  * **.NET 8**, .NET 7, .NET 6, .NET 5, Core 2x & 3x, Standard 2, and Framework 4.6.2+
  * Compatible with Systems including Windows, macOS, Linux; and Deployable via Docker, Azure, and AWS

[![IronWord Cross Platform Support](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronWord-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/word/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

Click this link to access [API reference materials](https://ironsoftware.com/csharp/word/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) and [comprehensive licensing guidelines](https://ironsoftware.com/csharp/word/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#trial-license).

### Installing IronWord

To use IronWord in your project, initiate the installation with this command in your package manager console:

    PM> Install-Package IronWord
    

Then, incorporate these using statements at the beginning of your C# application:

    using IronWord;
    using IronWord.Models;
    using IronSoftware.Drawing;
    
    // Create or load documents
    var existingDoc = new WordDocument("existing.docx");  // Loading an existing document
    
    var newDoc = new WordDocument();  // Creating a new document
    
    // Adding textual content
    var textParagraph = new Paragraph();
    textParagraph.AddText(new Text() { Text = "Hello IronWord!" });
    existingDoc.AddParagraph(textParagraph);
    
    // Incorporating images
    var img = new Image("example.jpg") { Width = 200, Height = 200 };
    var imageParagraph = new Paragraph();
    imageParagraph.AddImage(img);
    
    existingDoc.AddParagraph(imageParagraph);
    
    // Saving documents
    existingDoc.Save("updatedExisting.docx");  // Saving modifications
    existingDoc.SaveAs("newDocument.docx");  // Saving as a new file
    

### Feature Summary

[![IronWord Feature Overview](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronWord-readme/features-table.png)](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featuresbanner)

### Comprehensive Support & Licensing

For a full suite of code examples, licensing details, and documentation, make sure to visit us: [https://ironsoftware.com/csharp/word/](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)

Contact us for support at: support@ironsoftware.com

### Helpful Documentation Links

  * Step-by-Step Guides: [https://ironsoftware.com/csharp/word/how-to/](https://ironsoftware.com/csharp/word/how-to/html-file-to-pdf/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Sample Code: [https://ironsoftware.com/csharp/word/examples/](https://ironsoftware.com/csharp/word/examples/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Complete API Reference: [https://ironsoftware.com/csharp/word/object-reference/api/](https://ironsoftware.com/csharp/word/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Tutorial Portal: [https://ironsoftware.com/csharp/word/tutorials/](https://ironsoftware.com/csharp/word/tutorials/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Licensing Information: [https://ironsoftware.com/csharp/word/licensing/](https://ironsoftware.com/csharp/word/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Live Chat Assistance: [https://ironsoftware.com/csharp/word/#helpscout-support](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)