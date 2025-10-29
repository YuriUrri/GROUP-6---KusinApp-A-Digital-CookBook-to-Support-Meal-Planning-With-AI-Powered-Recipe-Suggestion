using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace KusinApp.Services
{
    [DesignerCategory("Code")]
    public class IncrementerButton : UserControl
    {
        private Button btnUp;
        private Button btnDown;

        public int CornerRadius { get; set; } = 10;
        public int Step { get; set; } = 1;
        public int Value { get; private set; } = 0;

        public Color ButtonColor { get; set; } = Color.FromArgb(252, 191, 73);
        public Color ArrowColor { get; set; } = Color.White;

        public event EventHandler<int> ValueChanged;

        public IncrementerButton()
        {
            this.Size = new Size(28, 40);
            this.BackColor = Color.Transparent;

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return; // Stop here in design mode to prevent crashes

            InitializeButtons();
        }

        private void InitializeButtons()
        {
            btnUp = new Button
            {
                Text = "▲",
                Font = new Font("Segoe UI", 6, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = this.Height / 2,
                FlatStyle = FlatStyle.Flat,
                BackColor = ButtonColor,
                ForeColor = ArrowColor
            };
            btnUp.FlatAppearance.BorderSize = 0;
            btnUp.Click += (s, e) => IncrementValue();

            btnDown = new Button
            {
                Text = "▼",
                Font = new Font("Segoe UI", 6, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                Height = this.Height / 2,
                FlatStyle = FlatStyle.Flat,
                BackColor = ButtonColor,
                ForeColor = ArrowColor
            };
            btnDown.FlatAppearance.BorderSize = 0;
            btnDown.Click += (s, e) => DecrementValue();

            this.Controls.Add(btnUp);
            this.Controls.Add(btnDown);
        }

        private void IncrementValue()
        {
            Value += Step;
            ValueChanged?.Invoke(this, Value);
        }

        private void DecrementValue()
        {
            if (Value - Step >= 0)
                Value -= Step;
            else
                Value = 0;

            ValueChanged?.Invoke(this, Value);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DesignMode) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                int r = CornerRadius;

                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
            }
        }
    }
}
