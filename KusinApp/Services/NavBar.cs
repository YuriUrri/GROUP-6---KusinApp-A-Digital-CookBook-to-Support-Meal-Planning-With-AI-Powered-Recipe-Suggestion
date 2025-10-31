using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace KusinApp.Components
{
    public class NavBar : UserControl
    {
        private int iconSize = 40;

        private readonly Image[] icons = new Image[3];

        private int hoveredIndex = -1;
        private int selectedIndex = -1;

        private readonly Color baseColor = ColorTranslator.FromHtml("#003049");

        private enum IconState { Normal, Hover, Selected }
        private IconState[] states = new IconState[3] { IconState.Normal, IconState.Normal, IconState.Normal };

        public event Action<int> SectionClicked;
        protected virtual void OnSectionClicked(int index) => SectionClicked?.Invoke(index);

        public NavBar()
        {
            this.BackColor = baseColor;
            this.Height = 60;
            this.DoubleBuffered = true;

            icons[0] = ByteArrayToImage(Properties.Resources.home);
            icons[1] = ByteArrayToImage(Properties.Resources.chef_hat);
            icons[2] = ByteArrayToImage(Properties.Resources.shopping_bag);

            this.MouseMove += NavBar_MouseMove;
            this.MouseLeave += NavBar_MouseLeave;
            this.MouseDown += NavBar_MouseDown;
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void NavBar_MouseMove(object sender, MouseEventArgs e)
        {
            int idx = GetSectionIndexAt(e.Location);
            for (int i = 0; i < 3; i++)
            {
                if (i == idx && i != selectedIndex)
                    states[i] = IconState.Hover;
                else if (i != selectedIndex)
                    states[i] = IconState.Normal;
            }
            hoveredIndex = idx;
            this.Invalidate();
        }

        private void NavBar_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                if (i != selectedIndex) states[i] = IconState.Normal;

            hoveredIndex = -1;
            this.Invalidate();
        }

        private void NavBar_MouseDown(object sender, MouseEventArgs e)
        {
            int idx = GetSectionIndexAt(e.Location);
            if (idx < 0 || idx > 2) return;

            bool alreadyOpen = idx switch
            {
                0 => Application.OpenForms.OfType<MainPage>().Any(),
                1 => Application.OpenForms.OfType<PersonalRecipe>().Any(),
                2 => Application.OpenForms.OfType<Inventory>().Any(),
                _ => false
            };

            if (alreadyOpen)
                return;

            selectedIndex = idx;
            for (int i = 0; i < 3; i++)
                states[i] = (i == selectedIndex) ? IconState.Selected : IconState.Normal;

            this.Invalidate();
            OpenFormAtIndex(idx);
        }

        private void OpenFormAtIndex(int idx)
        {
            Form currentForm = this.FindForm();
            switch (idx)
            {
                case 0:
                    if (!Application.OpenForms.OfType<MainPage>().Any())
                    {
                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                        currentForm?.Close();
                    }
                    break;
                case 1:
                    if (!Application.OpenForms.OfType<PersonalRecipe>().Any())
                    {
                        PersonalRecipe recipeSearch = new PersonalRecipe();
                        recipeSearch.Show();
                        currentForm?.Close();
                    }
                    break;
                case 2:
                    if (!Application.OpenForms.OfType<Inventory>().Any())
                    {
                        Inventory inventory = new Inventory();
                        inventory.Show();
                        currentForm?.Close();
                    }
                    break;
            }
        }

        private int GetSectionIndexAt(Point p)
        {
            if (this.Width <= 0) return -1;
            int sectionWidth = this.Width / 3;
            if (p.Y < 0 || p.Y > this.Height) return -1;

            int idx = p.X / sectionWidth;
            if (idx < 0) idx = 0;
            if (idx > 2) idx = 2;

            return idx;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int w = this.Width;
            int h = this.Height;

            // Fill base rectangle
            using (Brush bBase = new SolidBrush(baseColor))
                e.Graphics.FillRectangle(bBase, 0, 0, w, h);

            // Draw section shading
            int sectionW = w / 3;
            for (int i = 0; i < 3; i++)
            {
                Rectangle secRect = new Rectangle(i * sectionW, 0, sectionW, h);
                float shade = 0f;
                switch (states[i])
                {
                    case IconState.Normal: shade = 0f; break;
                    case IconState.Hover: shade = 0.12f; break;
                    case IconState.Selected: shade = 0.18f; break;
                }
                Color secCol = BlendWithBlack(baseColor, shade);
                using (Brush b = new SolidBrush(secCol))
                    e.Graphics.FillRectangle(b, secRect);
            }

            // Draw icons
            for (int i = 0; i < 3; i++)
            {
                double scale = (states[i] == IconState.Normal) ? 0.8 : 1.0;
                int drawW = (int)Math.Round(iconSize * scale);
                int drawH = (int)Math.Round(iconSize * scale);

                int centerX = i * sectionW + sectionW / 2;
                int centerY = h / 2;

                Rectangle drawRect = new Rectangle(centerX - drawW / 2, centerY - drawH / 2, drawW, drawH);

                if (icons[i] != null)
                {
                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    e.Graphics.DrawImage(icons[i], drawRect);
                }
            }
        }

        private Color BlendWithBlack(Color c, float factor)
        {
            int r = (int)Math.Round(c.R * (1 - factor));
            int g = (int)Math.Round(c.G * (1 - factor));
            int b = (int)Math.Round(c.B * (1 - factor));
            return Color.FromArgb(r, g, b);
        }
    }
}
