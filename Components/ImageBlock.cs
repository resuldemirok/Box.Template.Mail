namespace Box.Template.Mail.Components;

public class ImageBlock : IEmailComponent
{
    public string Src { get; set; } = string.Empty;
    public string Alt { get; set; } = "";
    public int Width { get; set; }
    public string Link { get; set; } = string.Empty;

    public string Render()
    {
        var imgTag = $"<img src=\"{Src}\" alt=\"{Alt}\" width=\"{Width}\" style=\"display:block;max-width:100%;\"/>";
        if (!string.IsNullOrEmpty(Link))
            return $"<a href=\"{Link}\">{imgTag}</a>";
        return imgTag;
    }
}
