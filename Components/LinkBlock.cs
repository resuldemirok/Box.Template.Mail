namespace Box.Template.Mail.Components;

public class LinkBlock : IEmailComponent
{
    public string Text { get; set; } = "Link";
    public string Url { get; set; } = "#";
    public string Color { get; set; } = "#007BFF";

    public string Render()
    {
        return $"<a href=\"{Url}\" style=\"color:{Color};text-decoration:underline;\">{Text}</a>";
    }
}
