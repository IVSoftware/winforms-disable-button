Here's a lightweight extended class that uses `ControlPaint.DrawButton` to render the blank button so that you can cleanly draw the colored text over it.

[![disabled button demo][1]][1]

```
protected override void OnPaint(PaintEventArgs e)
{
    if (Enabled)
    {
        base.OnPaint(e);
    }
    else
    {
        var buttonState = Enabled ? ButtonState.Normal : ButtonState.Inactive;
        ControlPaint.DrawButton(e.Graphics, ClientRectangle, buttonState);

        Color textColorWithTransparency = 
            Color.FromArgb(
                0xA0,                   
                ForeColorDisabled);
                
        using (var brush = new SolidBrush(textColorWithTransparency))
        {
            e.Graphics.DrawString(
                Text,
                Font,
                brush,
                ClientRectangle,
                new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
        }
    }
}
```

You can set the disabled fore color in the designer:

[![designer][2]][2]

___

_You will want to manually change instances of `Button` in the designer to instances of `ButtonEx`._

[![designer][3]][3]


___


  [1]: https://i.sstatic.net/Z41oJGAm.png
  [2]: https://i.sstatic.net/e4jMB2vI.png
  [3]: https://i.sstatic.net/jt8lCoEF.png