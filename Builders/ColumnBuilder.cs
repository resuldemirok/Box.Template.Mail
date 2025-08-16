using System.Collections.Generic;
using System.Linq;
using Box.Template.Mail.Components;

namespace Box.Template.Mail.Builders;

public class ColumnBuilder
{
    private readonly List<IEmailComponent> _components = new();
    public int WidthPercent { get; set; } = 100;

    public ColumnBuilder AddComponent(IEmailComponent component)
    {
        _components.Add(component);
        return this;
    }

    public string Render()
    {
        var content = string.Join("", _components.Select(c => c.Render()));
        return $"<td style=\"width:{WidthPercent}%;padding:10px;vertical-align:top;\">{content}</td>";
    }
}
