namespace StudentManagementSystem
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            SlidePanel = new Panel();
            SplashTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OFFICIAL_LOGO;
            pictureBox1.Location = new Point(316, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SlidePanel);
            panel1.Location = new Point(165, 420);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(607, 39);
            panel1.TabIndex = 1;
            // 
            // SlidePanel
            // 
            SlidePanel.BackColor = Color.FromArgb(237, 28, 46);
            SlidePanel.Location = new Point(4, 3);
            SlidePanel.Name = "SlidePanel";
            SlidePanel.Size = new Size(600, 33);
            SlidePanel.TabIndex = 0;
            // 
            // SplashTimer
            // 
            SplashTimer.Interval = 3000;
            SplashTimer.Tick += SplashTimer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 0, 33);
            ClientSize = new Size(950, 650);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel SlidePanel;
        private System.Windows.Forms.Timer SplashTimer;
    }
}