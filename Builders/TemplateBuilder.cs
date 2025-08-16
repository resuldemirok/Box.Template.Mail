using System;
using System.Collections.Generic;
using System.Linq;

namespace Box.Template.Mail.Builders;

public class TemplateBuilder
{
    private readonly List<RowBuilder> _rows = new();
    public string BackgroundColor { get; set; } = "#fff";
    public int Width { get; set; } = 600;

    public TemplateBuilder AddRow(Action<RowBuilder> configure)
    {
        var row = new RowBuilder();
        configure(row);
        _rows.Add(row);
        return this;
    }

    public string Build()
    {
        var rows = string.Join("", _rows.Select(r => r.Render()));
        
        return $@"
        <!DOCTYPE html>
        <html>
            <body style='margin:0;padding:0;background:{BackgroundColor};'>
                <table align='center' width='{Width}' cellpadding='0' cellspacing='0' border='0' style='border-collapse:collapse;'>
                    {rows}
                </table>
            </body>
        </html>";
    }
}
