using System.Diagnostics;
using System.Drawing;
using System.Numerics;

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
            MainPanel.SuspendLayout();
            for (int i = 0; i < colors.Count; i++)
            {
                Point coord = GetPosition(i);
                e.Graphics.FillEllipse(new SolidBrush(colors[i]), coord.X, coord.Y, ledsize, ledsize);
                e.Graphics.DrawEllipse(new Pen(Color.Gray), coord.X, coord.Y, ledsize, ledsize);
#if DEBUG
                e.Graphics.DrawString(i.ToString(), this.Font, Brushes.White, coord.X, coord.Y);
#endif
            }
            MainPanel.ResumeLayout();
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

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int ledno = GetLedNumber(e.X, e.Y);

            if (ledno > -1)
            {
                DebugLabel.Text = string.Format("{0}, {1}\r\nLED: {2}", e.X, e.Y, ledno);
                Color color = Color.FromArgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value);

                switch (e.Button)
                {
                    case MouseButtons.Right:
                        SetColor(ledno, Color.Black);
                        break;
                    case MouseButtons.Left:
                        SetColor(ledno, color);
                        break;
                    case MouseButtons.Middle:
                        break;
                    default:
                        break;
                }
            }
        }

        private void SetColor(int ledno, Color color)
        {
            if (colors[ledno] != color)
            {
                colors[ledno] = color;

                Point point = GetPosition(ledno);
                MainPanel.Invalidate(new Rectangle(point.X, point.Y, 32, 32));
                MainPanel.Update();

            }
        }

        private int GetLedNumber(int x, int y)
        {
            int result = -1;
            Vector2 center = new Vector2(x < 550 ? 250f : 850f, 300f);
            Vector2 end = new Vector2(x, y);

            float angle = GetAngle(center, end);
            float distance = (float)Math.Sqrt(MathF.Pow(end.X - center.X, 2) + MathF.Pow(end.Y - center.Y, 2));

            if (x > 550) angle += 180f;
            if (distance < 220)
            {
                if (distance > 180)
                {
                    angle = (angle + 97.5f) % 360;
                    result = (int)(angle / 15f);
                }
                else if (distance > 140)
                {
                    angle = (angle + 101.25f) % 360;
                    result = (int)(angle / 22.5f) + 24;
                }
                else if (distance > 100)
                {
                    angle = (angle + 105f) % 360;
                    result = (int)(angle / 30f) + 40;
                }
                else if (distance > 60)
                {
                    angle = (angle + 112.5f) % 360;
                    result = (int)(angle / 45f) + 52;
                }
            }
            if (x > 550) result += 60;
            DebugLabel.Text = string.Format("{0} - {1}\r\n{2}", angle, distance, result);

            return result;
        }

        public static float GetAngle(Vector2 point, Vector2 center)
        {
            Vector2 relPoint = point - center;
            return (ToDegrees(MathF.Atan2((float)relPoint.Y, (float)relPoint.X)) + 450f) % 360f;
        }

        public static float ToDegrees(float radians) => radians * 180f / MathF.PI;

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pixels; i++)
                colors[i] = Color.Black;

            MainPanel.Invalidate();
            MainPanel.Update();
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value);
            for (int i = 0; i < pixels; i++)
                colors[i] = color;

            MainPanel.Invalidate();
            MainPanel.Update();
        }
    }
}