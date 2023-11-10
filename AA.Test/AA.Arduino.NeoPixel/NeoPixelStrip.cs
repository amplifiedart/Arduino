using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.Arduino.NeoPixel
{
	public class NeoPixelStrip : NeoPixelCanvas
	{
		private int amountPixels;

		public int AmountPixels
		{
			get { return amountPixels; }
			set
			{
				amountPixels = value;
				UpdateControls();
			}
		}

        public int PixelSize { get; set; }

        private void UpdateControls()
		{
			this.Controls.Clear();
			for (int i = 0; i < amountPixels; i++)
			{

			}
		}
	}
}
