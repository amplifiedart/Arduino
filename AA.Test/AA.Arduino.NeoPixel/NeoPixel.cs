using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.Arduino.NeoPixel
{
	public class NeoPixel : Control, INeoPixelControl
	{
		private Color ledColor = Color.Black;
		private Color contrastColor = Color.White;

		public NeoPixel()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			BackColor = Color.Transparent;
			DoubleBuffered = true;
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		public Color LedColor
		{
			get { return ledColor; }
			set
			{
				ledColor = value;
				contrastColor = value.GetBrightness() > 0.5f ? Color.Black : Color.White;

				Invalidate();
			}
		}

		public int PixelIndex { get; set; }
		public int PixelCount
		{
			get
			{
				return this.Controls.Count > 0 ? this.Controls.OfType<INeoPixelControl>().Sum(c => c.PixelCount) : 1;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			int height = Height - Padding.Vertical;
			int width = Width - Padding.Horizontal;
			int diameter = width > height ? height : width;
			Point center = new Point(Width/2, Height/2);

			Rectangle box = new Rectangle(center.X - diameter / 2, center.Y - diameter / 2, diameter, diameter);
			e.Graphics.FillEllipse(new SolidBrush(LedColor), box);
			e.Graphics.DrawEllipse(new Pen(contrastColor), box);

			/* 
             * DEBUG Information included
             */
#if DEBUG
			SizeF floatSize = e.Graphics.MeasureString(PixelIndex.ToString(), this.Font);
			Size textSize = new Size((int)floatSize.Width, (int)floatSize.Height);
			box = new Rectangle(center.X - textSize.Width / 2, center.Y - textSize.Height / 2, textSize.Width, textSize.Height);
			e.Graphics.DrawString(PixelIndex.ToString(), this.Font, new SolidBrush(contrastColor), box);
#endif

			base.OnPaint(e);
		}
	}
}
