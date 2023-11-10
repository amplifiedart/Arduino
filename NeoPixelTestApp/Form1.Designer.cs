namespace NeoPixelTestApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			neoPixel1 = new AA.Arduino.NeoPixel.NeoPixel();
			neoPixel2 = new AA.Arduino.NeoPixel.NeoPixel();
			SuspendLayout();
			// 
			// neoPixel1
			// 
			neoPixel1.BackColor = Color.Transparent;
			neoPixel1.LedColor = Color.IndianRed;
			neoPixel1.Location = new Point(297, 104);
			neoPixel1.Name = "neoPixel1";
			neoPixel1.PixelIndex = 0;
			neoPixel1.Size = new Size(32, 32);
			neoPixel1.TabIndex = 0;
			neoPixel1.Text = "neoPixel1";
			// 
			// neoPixel2
			// 
			neoPixel2.BackColor = Color.Transparent;
			neoPixel2.BackgroundImageLayout = ImageLayout.None;
			neoPixel2.LedColor = Color.Lime;
			neoPixel2.Location = new Point(407, 104);
			neoPixel2.Name = "neoPixel2";
			neoPixel2.PixelIndex = 0;
			neoPixel2.Size = new Size(32, 32);
			neoPixel2.TabIndex = 1;
			neoPixel2.Text = "neoPixel2";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Navy;
			ClientSize = new Size(800, 450);
			Controls.Add(neoPixel2);
			Controls.Add(neoPixel1);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private AA.Arduino.NeoPixel.NeoPixel neoPixel1;
		private AA.Arduino.NeoPixel.NeoPixel neoPixel2;
	}
}