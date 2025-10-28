using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KusinApp.Services
{
    public class RoundedTextBox : TextBox
    {
        private const int EM_SETMARGINS = 0xD3;
        private const int EC_LEFTMARGIN = 0x1;
        private const int EC_RIGHTMARGIN = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public int CornerRadius { get; set; } = 10;
        public int LeftMargin { get; set; } = 20;
        public int TopPadding { get; set; } = 6;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetRoundedRegion();
            SetMargins();
        }

        private void SetMargins()
        {
            SendMessage(this.Handle, EM_SETMARGINS,
                (IntPtr)(EC_LEFTMARGIN | EC_RIGHTMARGIN),
                (IntPtr)(LeftMargin << 16 | LeftMargin));
        }

        private void SetRoundedRegion()
        {
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Apply top padding manually for single-line textboxes
            if (!this.Multiline)
            {
                int dy = TopPadding;
                SendMessage(this.Handle, 0x00B1, IntPtr.Zero, IntPtr.Zero); // force redraw
                this.AutoSize = false;
                this.Padding = new Padding(0, dy, 0, 0);
            }
        }
    }
}
