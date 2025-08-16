namespace Box.Template.Mail.Components;

public class ButtonBlock : IEmailComponent
{
    public string Text { get; set; } = "Click";
    public string Url { get; set; } = "#";
    public string BackgroundColor { get; set; } = "#007BFF";
    public string Color { get; set; } = "#FFF";
    public string Padding { get; set; } = "10px 20px";
    public string BorderRadius { get; set; } = "5px";

    public string Render()
    {
        return $"<a href=\"{Url}\" style=\"background:{BackgroundColor};color:{Color};padding:{Padding};border-radius:{BorderRadius};text-decoration:none;display:inline-block;\">{Text}</a>";
    }
}
