using System.Diagnostics;

namespace LedAnimator
{
    public partial class Form1 : Form
    {
        const int pixels = 120;
        const int ledsize = 32;
        List<Color> colors = new List<Color>(pixels);

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < pixels; i++) { if (colors.Count < pixels) { colors.Add(Color.Blue); } }
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < colors.Count; i++)
            {
                Point coord = GetPosition(i);
                e.Graphics.FillEllipse(new SolidBrush(colors[i]), coord.X, coord.Y, ledsize, ledsize);
                e.Graphics.DrawEllipse(new Pen(Color.Gray), coord.X, coord.Y, ledsize, ledsize);
#if DEBUG
                e.Graphics.DrawString(i.ToString(), this.Font, Brushes.White, coord.X, coord.Y);
#endif
            }
        }

        private Point GetPosition(int ledno)
        {
            double led = ledno;
            double y = 300;
            double x = 250;
            double radius = 200;
            double angle = 0;
            double shift = 0;

            if (ledno >= 60)
            {
                // Second rings to be placed on right side. 1st LED is on the left hand side.
                x += 600;
                led = ledno - 60;
                shift += 180;
            }

            if (led < 24)
            {
                // Outer ring 24 Leds angle per Led = 15°
                radius = 200;
                angle = 15 * led;
            }
            else if (led < 40)
            {
                // 2nd ring 16 leds angle per Led = 22.5°
                radius = 160;
                angle = 22.5 * (led - 24);

            }
            else if (led < 52)
            {
                radius = 120;
                angle = 30 * (led - 40);
            }
            else
            {
                radius = 80;
                angle = 45 * (led - 52);
            }
            angle += shift;

            Point point = new Point(
                (int)(x + radius * Math.Cos(angle * Math.PI / 180.0)) - 8,
                (int)(y + radius * Math.Sin(angle * Math.PI / 180.0)) - 8
            );

            // Console.WriteLine("Coordinate for Led {0:000}: {1}, {2}", ledno, point.X, point.Y);
#if DEBUG
            Debug.WriteLine("Coordinate for Led {0:000}: {1}, {2}", ledno, point.X, point.Y);
#endif
            return point;

        }

        private void ColorChange(object sender, EventArgs e)
        {
            Color selected = Color.FromArgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value);
            SelectedColorLabel.BackColor = selected;
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            int ledno = GetLedNumber(e.X, e.Y);

            DebugLabel.Text = string.Format("{0}, {1}\r\nLED: {2}", e.X, e.Y, ledno);

            if (ledno > -1)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        colors[ledno] = Color.Black;
                        break;
                    case MouseButtons.Right:
                        colors[ledno] = Color.FromArgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value);
                        break;
                    case MouseButtons.Middle:
                        break;
                    default:
                        break;
                }
            }
        }

        private int GetLedNumber(int x, int y)
        {
            return -1;
        }
    }
}