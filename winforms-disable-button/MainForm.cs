using System.ComponentModel;

namespace winforms_disable_button
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            checkBoxDisable.CheckedChanged += (sender, e) =>
            {
                customButton.Enabled = !checkBoxDisable.Checked;
            };
        }
    }
    class ButtonEx : Button
    {
        public ButtonEx() => EnabledChanged += (sender, e) => Invalidate();

        [Browsable(true)]
        public Color ForeColorDisabled { get; set; } = SystemColors.ControlText;
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
    }
}
