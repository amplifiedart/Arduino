namespace LedAnimator
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
            colorDialog1 = new ColorDialog();
            LeftPanel = new Panel();
            SelectedColorLabel = new Label();
            BlueValue = new Label();
            GreenValue = new Label();
            RedValue = new Label();
            BlueLabel = new Label();
            GreenLabel = new Label();
            RedLabel = new Label();
            BlueSlider = new TrackBar();
            GreenSlider = new TrackBar();
            RedSlider = new TrackBar();
            MainPanel = new Panel();
            DebugLabel = new Label();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlueSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedSlider).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(DebugLabel);
            LeftPanel.Controls.Add(SelectedColorLabel);
            LeftPanel.Controls.Add(BlueValue);
            LeftPanel.Controls.Add(GreenValue);
            LeftPanel.Controls.Add(RedValue);
            LeftPanel.Controls.Add(BlueLabel);
            LeftPanel.Controls.Add(GreenLabel);
            LeftPanel.Controls.Add(RedLabel);
            LeftPanel.Controls.Add(BlueSlider);
            LeftPanel.Controls.Add(GreenSlider);
            LeftPanel.Controls.Add(RedSlider);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.MaximumSize = new Size(400, 0);
            LeftPanel.MinimumSize = new Size(200, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(200, 792);
            LeftPanel.TabIndex = 1;
            // 
            // SelectedColorLabel
            // 
            SelectedColorLabel.BorderStyle = BorderStyle.Fixed3D;
            SelectedColorLabel.Location = new Point(30, 612);
            SelectedColorLabel.Name = "SelectedColorLabel";
            SelectedColorLabel.Size = new Size(132, 42);
            SelectedColorLabel.TabIndex = 5;
            SelectedColorLabel.Text = "Selected Color";
            SelectedColorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BlueValue
            // 
            BlueValue.AutoSize = true;
            BlueValue.Location = new Point(132, 577);
            BlueValue.Name = "BlueValue";
            BlueValue.Size = new Size(13, 15);
            BlueValue.TabIndex = 2;
            BlueValue.Text = "0";
            // 
            // GreenValue
            // 
            GreenValue.AutoSize = true;
            GreenValue.Location = new Point(81, 577);
            GreenValue.Name = "GreenValue";
            GreenValue.Size = new Size(13, 15);
            GreenValue.TabIndex = 3;
            GreenValue.Text = "0";
            // 
            // RedValue
            // 
            RedValue.AutoSize = true;
            RedValue.Location = new Point(30, 577);
            RedValue.Name = "RedValue";
            RedValue.Size = new Size(13, 15);
            RedValue.TabIndex = 4;
            RedValue.Text = "0";
            // 
            // BlueLabel
            // 
            BlueLabel.AutoSize = true;
            BlueLabel.Location = new Point(132, 44);
            BlueLabel.Name = "BlueLabel";
            BlueLabel.Size = new Size(30, 15);
            BlueLabel.TabIndex = 1;
            BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            GreenLabel.AutoSize = true;
            GreenLabel.Location = new Point(81, 44);
            GreenLabel.Name = "GreenLabel";
            GreenLabel.Size = new Size(38, 15);
            GreenLabel.TabIndex = 1;
            GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            RedLabel.AutoSize = true;
            RedLabel.Location = new Point(30, 44);
            RedLabel.Name = "RedLabel";
            RedLabel.Size = new Size(27, 15);
            RedLabel.TabIndex = 1;
            RedLabel.Text = "Red";
            // 
            // BlueSlider
            // 
            BlueSlider.Location = new Point(132, 62);
            BlueSlider.Maximum = 255;
            BlueSlider.Name = "BlueSlider";
            BlueSlider.Orientation = Orientation.Vertical;
            BlueSlider.Size = new Size(45, 512);
            BlueSlider.TabIndex = 0;
            BlueSlider.ValueChanged += ColorChange;
            // 
            // GreenSlider
            // 
            GreenSlider.Location = new Point(81, 62);
            GreenSlider.Maximum = 255;
            GreenSlider.Name = "GreenSlider";
            GreenSlider.Orientation = Orientation.Vertical;
            GreenSlider.Size = new Size(45, 512);
            GreenSlider.TabIndex = 0;
            GreenSlider.ValueChanged += ColorChange;
            // 
            // RedSlider
            // 
            RedSlider.Location = new Point(30, 62);
            RedSlider.Maximum = 255;
            RedSlider.Name = "RedSlider";
            RedSlider.Orientation = Orientation.Vertical;
            RedSlider.Size = new Size(45, 512);
            RedSlider.TabIndex = 0;
            RedSlider.ValueChanged += ColorChange;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1013, 792);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // DebugLabel
            // 
            DebugLabel.BorderStyle = BorderStyle.Fixed3D;
            DebugLabel.Location = new Point(30, 678);
            DebugLabel.Name = "DebugLabel";
            DebugLabel.Size = new Size(132, 60);
            DebugLabel.TabIndex = 6;
            DebugLabel.Text = "label1";
            DebugLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1213, 792);
            Controls.Add(MainPanel);
            Controls.Add(LeftPanel);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BlueSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedSlider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Panel LeftPanel;
        private Panel MainPanel;
        private Label RedLabel;
        private TrackBar BlueSlider;
        private TrackBar GreenSlider;
        private TrackBar RedSlider;
        private Label BlueLabel;
        private Label GreenLabel;
        private Label SelectedColorLabel;
        private Label BlueValue;
        private Label GreenValue;
        private Label RedValue;
        private Label DebugLabel;
    }
}