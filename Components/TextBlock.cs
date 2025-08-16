namespace Box.Template.Mail.Components;

public class TextBlock : IEmailComponent
{
    public string Text { get; set; }
    public string Color { get; set; } = "#000";
    public string FontSize { get; set; } = "14px";
    public bool Bold { get; set; }

    public string Render()
    {
        var style = $"color:{Color};font-size:{FontSize};{(Bold ? "font-weight:bold;" : "")}";
        return $"<p style=\"{style}\">{Text}</p>";
    }
}
