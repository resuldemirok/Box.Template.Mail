namespace Box.Template.Mail.Components;

public class SpacerBlock : IEmailComponent
{
    public int Height { get; set; } = 20;

    public string Render() => $"<div style=\"height:{Height}px;\"></div>";
}
