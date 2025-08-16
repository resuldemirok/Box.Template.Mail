namespace Box.Template.Mail.Components;

public class HtmlBlock : IEmailComponent
{
    public string Html { get; set; } = "";

    public string Render() => Html;
}
