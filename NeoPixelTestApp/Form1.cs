using System.Windows.Forms.VisualStyles;

namespace NeoPixelTestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DoubleBuffered = true;
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}
	}
}