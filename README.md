![Nuget](https://img.shields.io/nuget/v/IronWord?color=informational&label=latest)![Installs](https://img.shields.io/nuget/dt/IronWord?color=informational&label=installs&logo=nuget)![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%20522%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws)![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure)[![livechat](https://img.shields.io/badge/Live%20Chat:-24/5-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## IronWord - The C# Word Library

[![IronWord NuGet Trial Banner Image](https://ironsoftware.com/csharp/word/nuget-trial-banner.png)](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

IronWord, crafted by Iron Software, is a robust library empowering C# developers with tools to manipulate, create, and store Word documents in .NET applications and websites.

#### Key Functions of IronWord:

  * Manipulating, creating, and storing Word and DOCX files.
  * PageSetup: Customizing paper size, page orientation, margins, and background color.
  * TextRun: Managing text elements, styles, appending text, splitting, and integrating images.
  * TextStyle: Overseeing font type, size, color, boldness, italics, strikethrough, underlining, superscript, and subscript functionalities.
  * Paragraph: Incorporating text runs, images, shapes, aligning texts, and configuring bullets and numbering.
  * Table: Adjusting tables by adding rows, setting cell content, removing rows, merging cells, etc.
  * Image: Embedding images from files or streams, adjusting text wrapping, positioning, dimensions, and other characteristics.
  * Shape: Modifying text wrapping, positioning, dimensions, type of shapes, and rotation.

Explore more! _Head to [our homepage](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) for [detailed code samples](https://ironsoftware.com/csharp/word/examples/add-text/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) and a [comprehensive features list](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist)_

#### Cross-Platform Compatibility of IronWord Includes:

  * **.NET 8**, .NET 7, .NET 6, and .NET 5, Core 2x & 3x, Standard 2, and Framework 4.6.2+
  * Systems like Windows, macOS, Linux, Docker, Azure, and AWS

[![IronWord Cross Platform Support Image](https://ironsoftware.com/csharp/word/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/word/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

Visit our site for the [API document reference](https://ironsoftware.com/csharp/word/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) and [information on licenses](https://ironsoftware.com/csharp/word/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#trial-license).

### How to Implement IronWord

To initiate, install the IronWord NuGet package using the following command in your package manager console:

    PM> Install-Package IronWord
    
When installed, incorporate `using IronWord;` at the start of your C# scripts. Below is an illustrative example to assist with opening, modifying, and storing a document:

    using IronWord;
    using IronWord.Models;
    using IronSoftware.Drawing;
    
    // Load an existing Word document
    var docxCurrent = new WordDocument("existing.docx");
    
    // Or initiate a new Word document
    var docxNew = new WordDocument();
    
    // Creating a new paragraph with custom text
    Paragraph newParagraph = new Paragraph();
    var textContent = new Text()
    {
        Text = "Welcome to IronWord!"
    };
    newParagraph.AddText(textContent);
    
    docxCurrent.AddParagraph(newParagraph);
    
    // Including an image within a paragraph
    Image newImage = new Image("example.jpg");
    newImage.Width = 200;  // Specify width in pixels
    newImage.Height = 200; // Specify height in pixels
    
    newParagraph = new Paragraph();
    
    // Add the image
    newParagraph.AddImage(newImage);
    
    docxCurrent.AddParagraph(newParagraph);
    
    // Overwrite the existing document
    docxCurrent.Save("existing.docx");
    
    // Alternatively, save as a new document
    docxCurrent.SaveAs("output.docx");
    

### Feature Overview

[![IronWord Features](https://ironsoftware.com/csharp/word/features-table.png)](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featuresbanner)

### Licensing & Support

Explore our extensive [code examples, tutorials, licensing details, and documentation](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs).

For any assistance, contact us via email at: support@ironsoftware.com

### Helpful Documentation Links

  * How-To Guides: [https://ironsoftware.com/csharp/word/how-to/](https://ironsoftware.com/csharp/word/how-to/html-file-to-pdf/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * API Examples: [https://ironsoftware.com/csharp/word/examples/](https://ironsoftware.com/csharp/word/examples/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * API Reference: [https://ironsoftware.com/csharp/word/object-reference/api/](https://ironsoftware.com/csharp/word/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Tutorials: [https://ironsoftware.com/csharp/word/tutorials/](https://ironsoftware.com/csharp/word/tutorials/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Licensing Details: [https://ironsoftware.com/csharp/word/licensing/](https://ironsoftware.com/csharp/word/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Live Chat Support: [https://ironsoftware.com/csharp/word/#helpscout-support](https://ironsoftware.com/csharp/word/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)