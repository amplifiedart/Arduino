using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.Arduino.NeoPixel
{
	public class NeoPixelCanvas : Control, INeoPixelControl
	{
		public int PixelIndex { get; set; }

		public int PixelCount
		{
			get
			{
				return Controls.OfType<INeoPixelControl>().Sum(c => c.PixelCount);
			}
		}

		protected override void OnControlAdded(ControlEventArgs e)
		{
			UpdateNeoPixels();

			base.OnControlAdded(e);
		}


		protected override void OnControlRemoved(ControlEventArgs e)
		{
			UpdateNeoPixels();

			base.OnControlRemoved(e);
		}

		public void UpdateNeoPixels()
		{
			int offset = 0;
			foreach (var control in Controls) {
				if (control != null)
				{
					var neoPixelType = control.GetType();
					if ( neoPixelType == typeof(INeoPixelControl))
					{
						offset = UpdateNeoPixelControl(offset, control, neoPixelType);
					}
				}
			}
		}

		private static int UpdateNeoPixelControl(int offset, object control, Type neoPixelType)
		{
			INeoPixelControl pixel = (INeoPixelControl)control;
			pixel.PixelIndex = offset;

			if (neoPixelType == typeof(NeoPixelCanvas))
			{
				((NeoPixelCanvas)control).UpdateNeoPixels();
			}

			offset += pixel.PixelCount;
			return offset;
		}
	}
}
