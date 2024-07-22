namespace StudentManagementSystem
{
    partial class StudentManageForm
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
            panel2 = new Panel();
            label7 = new Label();
            StudentDataView = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            IDTB = new TextBox();
            IDLB = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ClearBtn = new Button();
            PhoneTB = new TextBox();
            PhoneLB = new Label();
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
            SearchBtn = new Button();
            searchTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)StudentDataView).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPhoto).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(128, 0, 33);
            panel2.Location = new Point(12, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 10);
            panel2.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(389, 15);
            label7.Name = "label7";
            label7.Size = new Size(163, 24);
            label7.TabIndex = 1;
            label7.Text = "Manage Student";
            // 
            // StudentDataView
            // 
            StudentDataView.AllowUserToAddRows = false;
            StudentDataView.AllowUserToDeleteRows = false;
            StudentDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataView.Location = new Point(13, 96);
            StudentDataView.Name = "StudentDataView";
            StudentDataView.RowTemplate.Height = 80;
            StudentDataView.Size = new Size(910, 278);
            StudentDataView.TabIndex = 40;
            StudentDataView.Click += StudentDataView_Click;
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
            panel1.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(IDTB);
            panel3.Controls.Add(IDLB);
            panel3.Controls.Add(UpdateBtn);
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(ClearBtn);
            panel3.Controls.Add(PhoneTB);
            panel3.Controls.Add(PhoneLB);
            panel3.Controls.Add(UploadBtn);
            panel3.Controls.Add(studentPhoto);
            panel3.Controls.Add(AddressTB);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(FemaleRB);
            panel3.Controls.Add(MaleRB);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(LNameTB);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(FNameTB);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 389);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 212);
            panel3.TabIndex = 42;
            // 
            // IDTB
            // 
            IDTB.Anchor = AnchorStyles.None;
            IDTB.Location = new Point(644, 112);
            IDTB.Name = "IDTB";
            IDTB.Size = new Size(91, 27);
            IDTB.TabIndex = 62;
            // 
            // IDLB
            // 
            IDLB.Anchor = AnchorStyles.None;
            IDLB.AutoSize = true;
            IDLB.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            IDLB.ForeColor = Color.FromArgb(128, 0, 33);
            IDLB.Location = new Point(573, 116);
            IDLB.Name = "IDLB";
            IDLB.Size = new Size(55, 18);
            IDLB.TabIndex = 61;
            IDLB.Text = "Id No : ";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.None;
            UpdateBtn.BackColor = Color.FromArgb(251, 210, 208);
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.FromArgb(128, 0, 33);
            UpdateBtn.Location = new Point(658, 173);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(110, 36);
            UpdateBtn.TabIndex = 60;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.None;
            DeleteBtn.BackColor = Color.FromArgb(128, 0, 33);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(774, 173);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(110, 36);
            DeleteBtn.TabIndex = 59;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.None;
            ClearBtn.BackColor = Color.White;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.FromArgb(128, 0, 33);
            ClearBtn.Location = new Point(537, 173);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(110, 36);
            ClearBtn.TabIndex = 58;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // PhoneTB
            // 
            PhoneTB.Anchor = AnchorStyles.None;
            PhoneTB.Location = new Point(608, 10);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(127, 27);
            PhoneTB.TabIndex = 57;
            // 
            // PhoneLB
            // 
            PhoneLB.Anchor = AnchorStyles.None;
            PhoneLB.AutoSize = true;
            PhoneLB.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            PhoneLB.ForeColor = Color.FromArgb(128, 0, 33);
            PhoneLB.Location = new Point(537, 14);
            PhoneLB.Name = "PhoneLB";
            PhoneLB.Size = new Size(65, 18);
            PhoneLB.TabIndex = 56;
            PhoneLB.Text = "Phone : ";
            // 
            // UploadBtn
            // 
            UploadBtn.Anchor = AnchorStyles.None;
            UploadBtn.BackColor = Color.White;
            UploadBtn.FlatStyle = FlatStyle.Flat;
            UploadBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UploadBtn.ForeColor = Color.FromArgb(128, 0, 33);
            UploadBtn.Location = new Point(774, 126);
            UploadBtn.Name = "UploadBtn";
            UploadBtn.Size = new Size(110, 29);
            UploadBtn.TabIndex = 55;
            UploadBtn.Text = "Upload";
            UploadBtn.UseVisualStyleBackColor = false;
            UploadBtn.Click += UploadBtn_Click;
            // 
            // studentPhoto
            // 
            studentPhoto.Anchor = AnchorStyles.None;
            studentPhoto.BackColor = Color.Gainsboro;
            studentPhoto.InitialImage = Properties.Resources.OFFICIAL_LOGO;
            studentPhoto.Location = new Point(774, 7);
            studentPhoto.Name = "studentPhoto";
            studentPhoto.Size = new Size(110, 111);
            studentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            studentPhoto.TabIndex = 54;
            studentPhoto.TabStop = false;
            // 
            // AddressTB
            // 
            AddressTB.Anchor = AnchorStyles.None;
            AddressTB.Location = new Point(158, 94);
            AddressTB.Multiline = true;
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(382, 63);
            AddressTB.TabIndex = 53;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(56, 104);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 52;
            label5.Text = "Address : ";
            // 
            // FemaleRB
            // 
            FemaleRB.Anchor = AnchorStyles.None;
            FemaleRB.AutoSize = true;
            FemaleRB.ForeColor = Color.FromArgb(128, 0, 33);
            FemaleRB.Location = new Point(658, 56);
            FemaleRB.Name = "FemaleRB";
            FemaleRB.Size = new Size(77, 22);
            FemaleRB.TabIndex = 51;
            FemaleRB.Text = "Female";
            FemaleRB.UseVisualStyleBackColor = true;
            // 
            // MaleRB
            // 
            MaleRB.Anchor = AnchorStyles.None;
            MaleRB.AutoSize = true;
            MaleRB.Checked = true;
            MaleRB.ForeColor = Color.FromArgb(128, 0, 33);
            MaleRB.Location = new Point(570, 58);
            MaleRB.Name = "MaleRB";
            MaleRB.Size = new Size(57, 22);
            MaleRB.TabIndex = 50;
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
            label4.Location = new Point(469, 60);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 49;
            label4.Text = "Gender : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(157, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 27);
            dateTimePicker1.TabIndex = 48;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 0, 33);
            label3.Location = new Point(24, 62);
            label3.Name = "label3";
            label3.Size = new Size(110, 18);
            label3.TabIndex = 47;
            label3.Text = "Date Of Birth : ";
            // 
            // LNameTB
            // 
            LNameTB.Anchor = AnchorStyles.None;
            LNameTB.Location = new Point(393, 10);
            LNameTB.Name = "LNameTB";
            LNameTB.Size = new Size(126, 27);
            LNameTB.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 0, 33);
            label2.Location = new Point(291, 14);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 45;
            label2.Text = "Last Name : ";
            // 
            // FNameTB
            // 
            FNameTB.Anchor = AnchorStyles.None;
            FNameTB.Location = new Point(157, 10);
            FNameTB.Name = "FNameTB";
            FNameTB.Size = new Size(128, 27);
            FNameTB.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 18);
            label1.TabIndex = 43;
            label1.Text = "First Name : ";
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.White;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.FromArgb(128, 0, 33);
            SearchBtn.Location = new Point(812, 57);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(110, 36);
            SearchBtn.TabIndex = 61;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // searchTB
            // 
            searchTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTB.Location = new Point(671, 63);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(127, 27);
            searchTB.TabIndex = 62;
            // 
            // StudentManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(searchTB);
            Controls.Add(SearchBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(StudentDataView);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentManageForm";
            Text = "StudentManageForm";
            Load += StudentManageForm_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label7;
        private DataGridView StudentDataView;
        private Panel panel1;
        private Panel panel3;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private TextBox PhoneTB;
        private Label PhoneLB;
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
        private Button SearchBtn;
        private TextBox searchTB;
        private TextBox IDTB;
        private Label IDLB;
    }
}