namespace StudentManagementSystem
{
    partial class ManageCourseForm
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
            CourseDataView = new DataGridView();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            UpdateBtn = new Button();
            CourseIDTB = new TextBox();
            DeleteBtn = new Button();
            ClearBtn = new Button();
            label3 = new Label();
            DescTB = new TextBox();
            HoursTB = new TextBox();
            label5 = new Label();
            label2 = new Label();
            CourseNameTB = new TextBox();
            label1 = new Label();
            searchTB = new TextBox();
            SearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CourseDataView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(399, 15);
            label7.Name = "label7";
            label7.Size = new Size(155, 24);
            label7.TabIndex = 1;
            label7.Text = "Manage Course";
            // 
            // CourseDataView
            // 
            CourseDataView.AllowUserToAddRows = false;
            CourseDataView.AllowUserToDeleteRows = false;
            CourseDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CourseDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CourseDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDataView.Location = new Point(12, 102);
            CourseDataView.Name = "CourseDataView";
            CourseDataView.RowTemplate.Height = 80;
            CourseDataView.Size = new Size(910, 305);
            CourseDataView.TabIndex = 44;
            CourseDataView.Click += CourseDataView_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(128, 0, 33);
            panel3.Location = new Point(12, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 10);
            panel3.TabIndex = 45;
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
            panel1.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(CourseIDTB);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(ClearBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DescTB);
            panel2.Controls.Add(HoursTB);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CourseNameTB);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 196);
            panel2.TabIndex = 46;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.None;
            UpdateBtn.BackColor = Color.FromArgb(251, 210, 208);
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.FromArgb(128, 0, 33);
            UpdateBtn.Location = new Point(681, 143);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(110, 36);
            UpdateBtn.TabIndex = 63;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CourseIDTB
            // 
            CourseIDTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CourseIDTB.Location = new Point(414, 73);
            CourseIDTB.Name = "CourseIDTB";
            CourseIDTB.Size = new Size(128, 27);
            CourseIDTB.TabIndex = 86;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.None;
            DeleteBtn.BackColor = Color.FromArgb(128, 0, 33);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(797, 143);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(110, 36);
            DeleteBtn.TabIndex = 62;
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
            ClearBtn.Location = new Point(560, 143);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(110, 36);
            ClearBtn.TabIndex = 61;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 0, 33);
            label3.Location = new Point(311, 79);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 85;
            label3.Text = "Course Id :";
            // 
            // DescTB
            // 
            DescTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DescTB.Location = new Point(151, 121);
            DescTB.Multiline = true;
            DescTB.Name = "DescTB";
            DescTB.Size = new Size(391, 63);
            DescTB.TabIndex = 84;
            // 
            // HoursTB
            // 
            HoursTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            HoursTB.Location = new Point(151, 73);
            HoursTB.Name = "HoursTB";
            HoursTB.Size = new Size(128, 27);
            HoursTB.TabIndex = 83;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(49, 124);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 80;
            label5.Text = "Description :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 0, 33);
            label2.Location = new Point(90, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 79;
            label2.Text = "Hour : ";
            // 
            // CourseNameTB
            // 
            CourseNameTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CourseNameTB.Location = new Point(151, 10);
            CourseNameTB.Name = "CourseNameTB";
            CourseNameTB.Size = new Size(391, 27);
            CourseNameTB.TabIndex = 78;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(113, 18);
            label1.TabIndex = 77;
            label1.Text = "Course Name :";
            // 
            // searchTB
            // 
            searchTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTB.Location = new Point(668, 64);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(127, 27);
            searchTB.TabIndex = 64;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.White;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.FromArgb(128, 0, 33);
            SearchBtn.Location = new Point(809, 58);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(110, 36);
            SearchBtn.TabIndex = 63;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(searchTB);
            Controls.Add(SearchBtn);
            Controls.Add(panel2);
            Controls.Add(CourseDataView);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)CourseDataView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView CourseDataView;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private TextBox CourseIDTB;
        private Label label3;
        private TextBox DescTB;
        private TextBox HoursTB;
        private Label label5;
        private Label label2;
        private TextBox CourseNameTB;
        private Label label1;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private TextBox searchTB;
        private Button SearchBtn;
    }
}