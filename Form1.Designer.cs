using System.Drawing;
using System.Windows.Forms;


namespace multiplayer_paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            toolStrip1 = new BigToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton12 = new ToolStripButton();
            toolStripButton11 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton13 = new ToolStripButton();
            toolStripButton14 = new ToolStripButton();
            toolStripButton15 = new ToolStripButton();
            toolStripButton16 = new ToolStripButton();
            toolStripButton17 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(34, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 450);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(26, 26);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton12, toolStripButton11, toolStripButton4, toolStripButton7, toolStripButton5, toolStripButton8, toolStripButton6, toolStripButton10, toolStripButton9, toolStripButton13, toolStripButton14, toolStripButton15, toolStripButton16, toolStripButton17 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1110, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(30, 30);
            toolStripButton1.Text = "Paint Brush";
            toolStripButton1.Click += paintBrush;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(30, 30);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += eraser;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(30, 30);
            toolStripButton3.Tag = "Black";
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += colorPicker;
            // 
            // toolStripButton12
            // 
            toolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton12.Image = (Image)resources.GetObject("toolStripButton12.Image");
            toolStripButton12.ImageTransparentColor = Color.Magenta;
            toolStripButton12.Name = "toolStripButton12";
            toolStripButton12.Size = new Size(30, 30);
            toolStripButton12.Tag = "Gray";
            toolStripButton12.Text = "toolStripButton12";
            toolStripButton12.Click += colorPicker;
            // 
            // toolStripButton11
            // 
            toolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton11.Image = (Image)resources.GetObject("toolStripButton11.Image");
            toolStripButton11.ImageTransparentColor = Color.Magenta;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Size = new Size(30, 30);
            toolStripButton11.Tag = "DarkRed";
            toolStripButton11.Text = "toolStripButton11";
            toolStripButton11.Click += colorPicker;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(30, 30);
            toolStripButton4.Tag = "Red";
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += colorPicker;
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(30, 30);
            toolStripButton7.Tag = "Yellow";
            toolStripButton7.Text = "toolStripButton7";
            toolStripButton7.Click += colorPicker;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(30, 30);
            toolStripButton5.Tag = "Green";
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += colorPicker;
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(30, 30);
            toolStripButton8.Tag = "LightBlue";
            toolStripButton8.Text = "toolStripButton8";
            toolStripButton8.Click += colorPicker;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(30, 30);
            toolStripButton6.Tag = "Blue";
            toolStripButton6.Text = "toolStripButton6";
            toolStripButton6.Click += colorPicker;
            // 
            // toolStripButton10
            // 
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(30, 30);
            toolStripButton10.Tag = "Purple";
            toolStripButton10.Text = "toolStripButton10";
            toolStripButton10.Click += colorPicker;
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(30, 30);
            toolStripButton9.Tag = "White";
            toolStripButton9.Text = "toolStripButton9";
            toolStripButton9.Click += colorPicker;
            // 
            // toolStripButton13
            // 
            toolStripButton13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton13.Image = (Image)resources.GetObject("toolStripButton13.Image");
            toolStripButton13.ImageTransparentColor = Color.Magenta;
            toolStripButton13.Name = "toolStripButton13";
            toolStripButton13.Size = new Size(30, 30);
            toolStripButton13.Text = "toolStripButton13";
            toolStripButton13.Click += clear;
            // 
            // toolStripButton14
            // 
            toolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton14.Image = (Image)resources.GetObject("toolStripButton14.Image");
            toolStripButton14.ImageTransparentColor = Color.Magenta;
            toolStripButton14.Name = "toolStripButton14";
            toolStripButton14.Size = new Size(30, 30);
            toolStripButton14.Text = "toolStripButton14";
            toolStripButton14.Click += circlePoly;
            // 
            // toolStripButton15
            // 
            toolStripButton15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton15.Image = (Image)resources.GetObject("toolStripButton15.Image");
            toolStripButton15.ImageTransparentColor = Color.Magenta;
            toolStripButton15.Name = "toolStripButton15";
            toolStripButton15.Size = new Size(30, 30);
            toolStripButton15.Text = "toolStripButton15";
            toolStripButton15.Click += squarePoly;
            // 
            // toolStripButton16
            // 
            toolStripButton16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton16.Image = (Image)resources.GetObject("toolStripButton16.Image");
            toolStripButton16.ImageTransparentColor = Color.Magenta;
            toolStripButton16.Name = "toolStripButton16";
            toolStripButton16.Size = new Size(30, 30);
            toolStripButton16.Text = "toolStripButton16";
            toolStripButton16.Click += trianglePoly;
            // 
            // toolStripButton17
            // 
            toolStripButton17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton17.Image = (Image)resources.GetObject("toolStripButton17.Image");
            toolStripButton17.ImageTransparentColor = Color.Magenta;
            toolStripButton17.Name = "toolStripButton17";
            toolStripButton17.Size = new Size(30, 30);
            toolStripButton17.Text = "toolStripButton17";
            toolStripButton17.Click += textButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1110, 529);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "multiplayer-paint";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private BigToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton12;
        private ToolStripButton toolStripButton13;
        private ToolStripButton toolStripButton14;
        private ToolStripButton toolStripButton15;
        private ToolStripButton toolStripButton16;
        private ToolStripButton toolStripButton17;
    }
}
