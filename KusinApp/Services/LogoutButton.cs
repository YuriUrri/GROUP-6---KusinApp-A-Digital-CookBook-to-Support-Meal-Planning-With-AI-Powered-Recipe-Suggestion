using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.IO;

namespace KusinApp.Components
{
    public class LogoutButton : UserControl
    {
        private Image logoutIcon;
        private float scale = 1f;
        private bool isHovered = false;
        private bool isAnimating = false;

        public event EventHandler Clicked;

        public LogoutButton()
        {
            this.Size = new Size(50, 50);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;

            byte[] iconBytes = Properties.Resources.log_out;
            logoutIcon = ByteArrayToImage(iconBytes);
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int diameter = Math.Min(this.Width, this.Height);

            Color hoverColor = isHovered
                ? Color.FromArgb(180, Color.FromArgb(0xE5, 0xB4, 0x55))
                : Color.Transparent;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, diameter - 1, diameter - 1);
                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(hoverColor))
                    g.FillEllipse(brush, 0, 0, diameter, diameter);
            }

            if (logoutIcon != null)
            {
                int iconSize = (int)(diameter * 0.6f * scale);
                int x = (this.Width - iconSize) / 2;
                int y = (this.Height - iconSize) / 2;
                g.DrawImage(logoutIcon, x, y, iconSize, iconSize);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }

        protected override async void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (isAnimating)
                return;

            isAnimating = true;
            await AnimateClickAsync();
            isAnimating = false;

            PerformLogout();
        }

        private void PerformLogout()
        {
            Clicked?.Invoke(this, EventArgs.Empty);

            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            Form currentForm = this.FindForm();
            currentForm?.Close();
        }

        private async Task AnimateClickAsync()
        {
            // Shrink
            for (int i = 0; i < 3; i++)
            {
                scale -= 0.05f;
                Invalidate();
                await Task.Delay(10);
            }

            // Expand
            for (int i = 0; i < 3; i++)
            {
                scale += 0.05f;
                Invalidate();
                await Task.Delay(10);
            }

            scale = 1f;
            Invalidate();
        }
    }
}
