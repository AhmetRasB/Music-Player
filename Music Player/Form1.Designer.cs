namespace Music_Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection5 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toggleButton1 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton3 = new Syncfusion.WinForms.Controls.SfButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sfButton4 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton5 = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(-1, -2);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(771, 244);
            this.Player.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-1, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 32);
            this.textBox1.TabIndex = 1;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toggleButton1.ForeColor = System.Drawing.Color.Black;
            this.toggleButton1.Location = new System.Drawing.Point(22, 248);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(90, 40);
            this.toggleButton1.Slider = sliderCollection5;
            this.toggleButton1.TabIndex = 2;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.Click += new System.EventHandler(this.toggleButton1_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.sfButton1.Location = new System.Drawing.Point(124, 248);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(146, 40);
            this.sfButton1.TabIndex = 3;
            this.sfButton1.Text = "Browse";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.sfButton2.Location = new System.Drawing.Point(462, 248);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(146, 40);
            this.sfButton2.TabIndex = 4;
            this.sfButton2.Text = "Stop";
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // sfButton3
            // 
            this.sfButton3.AccessibleName = "Button";
            this.sfButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.sfButton3.Location = new System.Drawing.Point(614, 248);
            this.sfButton3.Name = "sfButton3";
            this.sfButton3.Size = new System.Drawing.Size(146, 40);
            this.sfButton3.TabIndex = 5;
            this.sfButton3.Text = "Exit";
            this.sfButton3.Click += new System.EventHandler(this.sfButton3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sfButton4
            // 
            this.sfButton4.AccessibleName = "Button";
            this.sfButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.sfButton4.Location = new System.Drawing.Point(369, 248);
            this.sfButton4.Name = "sfButton4";
            this.sfButton4.Size = new System.Drawing.Size(87, 40);
            this.sfButton4.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfButton4.TabIndex = 6;
            this.sfButton4.Click += new System.EventHandler(this.sfButton4_Click);
            // 
            // sfButton5
            // 
            this.sfButton5.AccessibleName = "Button";
            this.sfButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.sfButton5.Location = new System.Drawing.Point(276, 248);
            this.sfButton5.Name = "sfButton5";
            this.sfButton5.Size = new System.Drawing.Size(87, 40);
            this.sfButton5.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfButton5.TabIndex = 7;
            this.sfButton5.Click += new System.EventHandler(this.sfButton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(772, 298);
            this.Controls.Add(this.sfButton5);
            this.Controls.Add(this.sfButton4);
            this.Controls.Add(this.sfButton3);
            this.Controls.Add(this.sfButton2);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TextBox textBox1;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton sfButton3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Syncfusion.WinForms.Controls.SfButton sfButton4;
        private Syncfusion.WinForms.Controls.SfButton sfButton5;
    }
}

