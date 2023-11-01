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
            FrameLabel = new Label();
            NextFrameButton = new Button();
            PreviousFrameButton = new Button();
            FillButton = new Button();
            ClearButton = new Button();
            DebugLabel = new Label();
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
            panel1 = new Panel();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlueSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedSlider).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(FrameLabel);
            LeftPanel.Controls.Add(NextFrameButton);
            LeftPanel.Controls.Add(PreviousFrameButton);
            LeftPanel.Controls.Add(FillButton);
            LeftPanel.Controls.Add(ClearButton);
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
            LeftPanel.Size = new Size(200, 902);
            LeftPanel.TabIndex = 1;
            // 
            // FrameLabel
            // 
            FrameLabel.Location = new Point(62, 816);
            FrameLabel.Name = "FrameLabel";
            FrameLabel.Size = new Size(71, 26);
            FrameLabel.TabIndex = 9;
            FrameLabel.Text = "0";
            FrameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NextFrameButton
            // 
            NextFrameButton.ForeColor = Color.Black;
            NextFrameButton.Location = new Point(135, 812);
            NextFrameButton.Name = "NextFrameButton";
            NextFrameButton.Size = new Size(29, 30);
            NextFrameButton.TabIndex = 8;
            NextFrameButton.Text = ">";
            NextFrameButton.UseVisualStyleBackColor = true;
            // 
            // PreviousFrameButton
            // 
            PreviousFrameButton.ForeColor = Color.Black;
            PreviousFrameButton.Location = new Point(28, 812);
            PreviousFrameButton.Name = "PreviousFrameButton";
            PreviousFrameButton.Size = new Size(29, 30);
            PreviousFrameButton.TabIndex = 8;
            PreviousFrameButton.Text = "<";
            PreviousFrameButton.UseVisualStyleBackColor = true;
            // 
            // FillButton
            // 
            FillButton.ForeColor = Color.Black;
            FillButton.Location = new Point(28, 777);
            FillButton.Name = "FillButton";
            FillButton.Size = new Size(136, 29);
            FillButton.TabIndex = 7;
            FillButton.Text = "Fill";
            FillButton.UseVisualStyleBackColor = true;
            FillButton.Click += FillButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.Black;
            ClearButton.Location = new Point(28, 742);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(136, 29);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DebugLabel
            // 
            DebugLabel.BorderStyle = BorderStyle.Fixed3D;
            DebugLabel.Location = new Point(30, 678);
            DebugLabel.Name = "DebugLabel";
            DebugLabel.Size = new Size(132, 46);
            DebugLabel.TabIndex = 6;
            DebugLabel.Text = "label1";
            DebugLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            MainPanel.Controls.Add(panel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1013, 902);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 742);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 160);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1213, 902);
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
            MainPanel.ResumeLayout(false);
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
        private Label FrameLabel;
        private Button NextFrameButton;
        private Button PreviousFrameButton;
        private Button FillButton;
        private Button ClearButton;
        private Panel panel1;
    }
}