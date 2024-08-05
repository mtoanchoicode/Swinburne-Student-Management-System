namespace StudentManagementSystem
{
    partial class LoginForm
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            usernameTB = new TextBox();
            PasswordTB = new TextBox();
            LoginBtn = new Button();
            ExitBtn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 0, 33);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 650);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplon Norm Light Italic", 10.9999981F);
            label4.Location = new Point(194, 610);
            label4.Name = "label4";
            label4.Size = new Size(185, 17);
            label4.TabIndex = 4;
            label4.Text = "© Copy Right to Toan Truong";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplon Norm Bold", 23.9999962F, FontStyle.Bold);
            label3.Location = new Point(244, 367);
            label3.Name = "label3";
            label3.Size = new Size(123, 37);
            label3.TabIndex = 3;
            label3.Text = "System";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 23.9999962F, FontStyle.Bold);
            label2.Location = new Point(49, 306);
            label2.Name = "label2";
            label2.Size = new Size(327, 37);
            label2.TabIndex = 2;
            label2.Text = "Student Management";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 23.9999962F, FontStyle.Bold);
            label1.Location = new Point(62, 249);
            label1.Name = "label1";
            label1.Size = new Size(317, 37);
            label1.TabIndex = 1;
            label1.Text = "Swinburne University";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OFFICIAL_LOGO;
            pictureBox1.Location = new Point(97, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(581, 194);
            label5.Name = "label5";
            label5.Size = new Size(176, 24);
            label5.TabIndex = 1;
            label5.Text = "Please login first !";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(128, 0, 33);
            label6.Location = new Point(458, 239);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 2;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(128, 0, 33);
            label7.Location = new Point(458, 318);
            label7.Name = "label7";
            label7.Size = new Size(74, 18);
            label7.TabIndex = 3;
            label7.Text = "Password";
            // 
            // usernameTB
            // 
            usernameTB.Font = new Font("Simplon Norm", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTB.Location = new Point(458, 260);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(408, 30);
            usernameTB.TabIndex = 4;
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Simplon Norm", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTB.Location = new Point(458, 338);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(408, 30);
            PasswordTB.TabIndex = 5;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(128, 0, 33);
            LoginBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(458, 387);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(408, 42);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.AutoSize = true;
            ExitBtn.Font = new Font("Simplon Norm Bold", 23.9999962F, FontStyle.Bold);
            ExitBtn.ForeColor = Color.FromArgb(128, 0, 33);
            ExitBtn.Location = new Point(901, 9);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(37, 37);
            ExitBtn.TabIndex = 7;
            ExitBtn.Text = "X";
            ExitBtn.TextAlign = ContentAlignment.MiddleRight;
            ExitBtn.Click += ExitBtn_Click;
            ExitBtn.MouseEnter += ExitBtn_MouseEnter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTB);
            Controls.Add(usernameTB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox usernameTB;
        private TextBox PasswordTB;
        private Button LoginBtn;
        private Label ExitBtn;
    }
}