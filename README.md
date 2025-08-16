# Box.Template.Mail

Box.Template.Mail is a .NET library designed to make building modern, flexible, and dynamic email templates easy. With its row–column based structure, developers can quickly create email layouts that are fully compatible with HTML and inline CSS standards.

With Box.Template.Mail, you can:
- Define dynamic rows and columns for flexible email layouts
- Add different content types such as text, image, link, button, HTML content, divider, and spacer into cells
- Control image sizing, add links, and set alt text for accessibility
- Customize text with font size, color, bold, italic, and hyperlink options
- Create styled buttons with background color, text color, and clickable links
- Build templates programmatically with a clean and intuitive fluent API
- Generate production-ready HTML output optimized for email clients using inline CSS

---

## Installation

You can install the package via NuGet:

```powershell
dotnet add package Box.Template.Mail
```

---

## Example Usage

Below is an example of how to use Box.Template.Mail:

```csharp
using Box.Template.Mail.Models;
using Box.Template.Mail.Services;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var template = new TemplateBuilder { BackgroundColor = "#f5f5f5", Width = 700 }
            .AddRow(row => row
                .AddColumn(100, col => col.AddComponent(new ImageBlock
                {
                    Src = "https://via.placeholder.com/600x200",
                    Alt = "Hero Image",
                    Width = 600
                })))
            .AddRow(row => row
                .AddColumn(100, col => col.AddComponent(new TextBlock
                {
                    Text = "Hello, this is an example of an email template.",
                    FontSize = "16px",
                    Bold = true
                })))
            .AddRow(row => row
                .AddColumn(50, col => col.AddComponent(new ButtonBlock
                {
                    Text = "Check it out now",
                    Url = "https://example.com",
                    BackgroundColor = "#28a745"
                }))
                .AddColumn(50, col => col.AddComponent(new LinkBlock
                {
                    Text = "Unsubscribe",
                    Url = "https://example.com/unsubscribe",
                    Color = "#999"
                })))
            .Build();

        Console.WriteLine(template);
    }
}
```