namespace StudentManagementSystem
{
    partial class CourseForm
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
            label7 = new Label();
            panel1 = new Panel();
            CourseDataView = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            CourseNameTB = new TextBox();
            label2 = new Label();
            label5 = new Label();
            ClearBtn = new Button();
            AddBtn = new Button();
            HoursTB = new TextBox();
            DescTB = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDataView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(410, 15);
            label7.Name = "label7";
            label7.Size = new Size(156, 31);
            label7.TabIndex = 1;
            label7.Text = "New Course";
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
            panel1.TabIndex = 20;
            // 
            // CourseDataView
            // 
            CourseDataView.AllowUserToAddRows = false;
            CourseDataView.AllowUserToDeleteRows = false;
            CourseDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CourseDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CourseDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDataView.Location = new Point(12, 72);
            CourseDataView.Name = "CourseDataView";
            CourseDataView.RowHeadersWidth = 51;
            CourseDataView.RowTemplate.Height = 80;
            CourseDataView.Size = new Size(910, 300);
            CourseDataView.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(128, 0, 33);
            panel3.Location = new Point(12, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 10);
            panel3.TabIndex = 41;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 69;
            label1.Text = "Course Name :";
            // 
            // CourseNameTB
            // 
            CourseNameTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CourseNameTB.Location = new Point(151, 15);
            CourseNameTB.Name = "CourseNameTB";
            CourseNameTB.Size = new Size(384, 31);
            CourseNameTB.TabIndex = 70;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 0, 33);
            label2.Location = new Point(70, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 71;
            label2.Text = "Hour : ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(29, 129);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 72;
            label5.Text = "Description :";
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearBtn.BackColor = Color.FromArgb(251, 210, 208);
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = Color.FromArgb(128, 0, 33);
            ClearBtn.Location = new Point(653, 172);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(110, 36);
            ClearBtn.TabIndex = 73;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click_1;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(128, 0, 33);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(769, 172);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 36);
            AddBtn.TabIndex = 74;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // HoursTB
            // 
            HoursTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            HoursTB.Location = new Point(151, 78);
            HoursTB.Name = "HoursTB";
            HoursTB.Size = new Size(128, 31);
            HoursTB.TabIndex = 75;
            // 
            // DescTB
            // 
            DescTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DescTB.Location = new Point(151, 126);
            DescTB.Multiline = true;
            DescTB.Name = "DescTB";
            DescTB.Size = new Size(384, 63);
            DescTB.TabIndex = 76;
            // 
            // panel2
            // 
            panel2.Controls.Add(DescTB);
            panel2.Controls.Add(HoursTB);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(ClearBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CourseNameTB);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 223);
            panel2.TabIndex = 42;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel2);
            Controls.Add(CourseDataView);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDataView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private DataGridView CourseDataView;
        private Panel panel3;
        private Label label1;
        private TextBox CourseNameTB;
        private Label label2;
        private Label label5;
        private Button ClearBtn;
        private Button AddBtn;
        private TextBox HoursTB;
        private TextBox DescTB;
        private Panel panel2;
    }
}