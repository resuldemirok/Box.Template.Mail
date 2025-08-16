using System;
using System.Collections.Generic;
using System.Linq;

namespace Box.Template.Mail.Builders;

public class RowBuilder
{
    private readonly List<ColumnBuilder> _columns = new();

    public RowBuilder AddColumn(int widthPercent, Action<ColumnBuilder> configure)
    {
        var column = new ColumnBuilder { WidthPercent = widthPercent };
        configure(column);
        _columns.Add(column);
        return this;
    }

    public string Render()
    {
        var totalWidth = _columns.Sum(c => c.WidthPercent);
        if (totalWidth == 0) return "<tr></tr>";
        
        var previousWidth = 0;

        for (int i = 0; i < _columns.Count; i++)
        {
            if (i < _columns.Count - 1)
            {
                _columns[i].WidthPercent = (int)((_columns[i + 1].WidthPercent / totalWidth) * 100);
                previousWidth += _columns[i].WidthPercent;
            }
            else
                _columns[i].WidthPercent = 100 - previousWidth;
        }
        
        var cols = string.Join("", _columns.Select(c => c.Render()));
        return $"<tr>{cols}</tr>";
    }
}
