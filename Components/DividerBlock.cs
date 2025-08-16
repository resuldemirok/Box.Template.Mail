namespace Box.Template.Mail.Components;

public class DividerBlock : IEmailComponent
{
    public string Color { get; set; } = "#ddd";
    public int Thickness { get; set; } = 1;

    public string Render() => $"<hr style=\"border:{Thickness}px solid {Color};margin:10px 0;\"/>";
}
