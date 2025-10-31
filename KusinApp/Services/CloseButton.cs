using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.IO;

namespace KusinApp.Components
{
    public class CloseButton : UserControl
    {
        private Image closeIcon;
        private float scale = 1f;
        private bool isHovered = false;
        private bool isAnimating = false;

        public event EventHandler Clicked;

        public CloseButton()
        {
            this.Size = new Size(50, 50);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;

            byte[] iconBytes = Properties.Resources.close;
            closeIcon = ByteArrayToImage(iconBytes);
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

            if (closeIcon != null)
            {
                int iconSize = (int)(diameter * 0.6f * scale);
                int x = (this.Width - iconSize) / 2;
                int y = (this.Height - iconSize) / 2;
                g.DrawImage(closeIcon, x, y, iconSize, iconSize);
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

            PerformClose();
        }

        private void PerformClose()
        {
            Clicked?.Invoke(this, EventArgs.Empty);

            Form currentForm = this.FindForm();
            if (currentForm is LoginPage loginPage)
            {
                // If we're on LoginPage, hide the panel instead of closing the form
                loginPage.HidePanel();
            }
            else
            {
                // On other forms, close normally
                MainPage mainPage = new MainPage();
                mainPage.Show();
                currentForm?.Close();
            }
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
