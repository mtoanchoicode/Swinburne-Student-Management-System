namespace StudentManagementSystem
{
    partial class RegisterForm
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
            label7 = new Label();
            StudentDataView = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            AddBtn = new Button();
            ClearBtn = new Button();
            PhoneTB = new TextBox();
            label6 = new Label();
            UploadBtn = new Button();
            studentPhoto = new PictureBox();
            AddressTB = new TextBox();
            label5 = new Label();
            FemaleRB = new RadioButton();
            MaleRB = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            LNameTB = new TextBox();
            label2 = new Label();
            FNameTB = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPhoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 0, 33);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 52);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(410, 15);
            label7.Name = "label7";
            label7.Size = new Size(126, 24);
            label7.TabIndex = 1;
            label7.Text = "Registration";
            // 
            // StudentDataView
            // 
            StudentDataView.AllowUserToAddRows = false;
            StudentDataView.AllowUserToDeleteRows = false;
            StudentDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataView.Location = new Point(12, 70);
            StudentDataView.Name = "StudentDataView";
            StudentDataView.RowTemplate.Height = 80;
            StudentDataView.Size = new Size(910, 274);
            StudentDataView.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(ClearBtn);
            panel2.Controls.Add(PhoneTB);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(UploadBtn);
            panel2.Controls.Add(studentPhoto);
            panel2.Controls.Add(AddressTB);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(FemaleRB);
            panel2.Controls.Add(MaleRB);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(LNameTB);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(FNameTB);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 271);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(128, 0, 33);
            panel3.Location = new Point(12, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 10);
            panel3.TabIndex = 39;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(128, 0, 33);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(775, 216);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 36);
            AddBtn.TabIndex = 38;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearBtn.BackColor = Color.FromArgb(251, 210, 208);
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.FromArgb(128, 0, 33);
            ClearBtn.Location = new Point(659, 216);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(110, 36);
            ClearBtn.TabIndex = 37;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // PhoneTB
            // 
            PhoneTB.Anchor = AnchorStyles.None;
            PhoneTB.Location = new Point(609, 37);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(127, 27);
            PhoneTB.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(128, 0, 33);
            label6.Location = new Point(538, 41);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 35;
            label6.Text = "Phone : ";
            // 
            // UploadBtn
            // 
            UploadBtn.Anchor = AnchorStyles.None;
            UploadBtn.BackColor = Color.White;
            UploadBtn.FlatStyle = FlatStyle.Flat;
            UploadBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UploadBtn.ForeColor = Color.FromArgb(128, 0, 33);
            UploadBtn.Location = new Point(775, 155);
            UploadBtn.Name = "UploadBtn";
            UploadBtn.Size = new Size(110, 29);
            UploadBtn.TabIndex = 34;
            UploadBtn.Text = "Upload";
            UploadBtn.UseVisualStyleBackColor = false;
            UploadBtn.Click += UploadBtn_Click;
            // 
            // studentPhoto
            // 
            studentPhoto.Anchor = AnchorStyles.None;
            studentPhoto.BackColor = Color.Gainsboro;
            studentPhoto.InitialImage = Properties.Resources.OFFICIAL_LOGO;
            studentPhoto.Location = new Point(775, 36);
            studentPhoto.Name = "studentPhoto";
            studentPhoto.Size = new Size(110, 111);
            studentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            studentPhoto.TabIndex = 33;
            studentPhoto.TabStop = false;
            // 
            // AddressTB
            // 
            AddressTB.Anchor = AnchorStyles.None;
            AddressTB.Location = new Point(159, 121);
            AddressTB.Multiline = true;
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(578, 63);
            AddressTB.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(57, 131);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 31;
            label5.Text = "Address : ";
            // 
            // FemaleRB
            // 
            FemaleRB.Anchor = AnchorStyles.None;
            FemaleRB.AutoSize = true;
            FemaleRB.ForeColor = Color.FromArgb(128, 0, 33);
            FemaleRB.Location = new Point(659, 83);
            FemaleRB.Name = "FemaleRB";
            FemaleRB.Size = new Size(77, 22);
            FemaleRB.TabIndex = 30;
            FemaleRB.Text = "Female";
            FemaleRB.UseVisualStyleBackColor = true;
            // 
            // MaleRB
            // 
            MaleRB.Anchor = AnchorStyles.None;
            MaleRB.AutoSize = true;
            MaleRB.Checked = true;
            MaleRB.ForeColor = Color.FromArgb(128, 0, 33);
            MaleRB.Location = new Point(571, 85);
            MaleRB.Name = "MaleRB";
            MaleRB.Size = new Size(57, 22);
            MaleRB.TabIndex = 29;
            MaleRB.TabStop = true;
            MaleRB.Text = "Male";
            MaleRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(128, 0, 33);
            label4.Location = new Point(470, 87);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 28;
            label4.Text = "Gender : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(158, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 0, 33);
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(110, 18);
            label3.TabIndex = 26;
            label3.Text = "Date Of Birth : ";
            // 
            // LNameTB
            // 
            LNameTB.Anchor = AnchorStyles.None;
            LNameTB.Location = new Point(394, 37);
            LNameTB.Name = "LNameTB";
            LNameTB.Size = new Size(126, 27);
            LNameTB.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 0, 33);
            label2.Location = new Point(292, 41);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 24;
            label2.Text = "Last Name : ";
            // 
            // FNameTB
            // 
            FNameTB.Anchor = AnchorStyles.None;
            FNameTB.Location = new Point(158, 37);
            FNameTB.Name = "FNameTB";
            FNameTB.Size = new Size(128, 27);
            FNameTB.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(97, 18);
            label1.TabIndex = 22;
            label1.Text = "First Name : ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 613);
            Controls.Add(panel2);
            Controls.Add(StudentDataView);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private DataGridView StudentDataView;
        private Panel panel2;
        private Panel panel3;
        private Button AddBtn;
        private Button ClearBtn;
        private TextBox PhoneTB;
        private Label label6;
        private Button UploadBtn;
        private PictureBox studentPhoto;
        private TextBox AddressTB;
        private Label label5;
        private RadioButton FemaleRB;
        private RadioButton MaleRB;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox LNameTB;
        private Label label2;
        private TextBox FNameTB;
        private Label label1;
    }
}