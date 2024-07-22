namespace StudentManagementSystem
{
    partial class ManageScoreForm
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
            searchTB = new TextBox();
            SearchBtn = new Button();
            ScoreDataView = new DataGridView();
            panel3 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            SelectCourseCB = new ComboBox();
            DescTB = new TextBox();
            ScoreTB = new TextBox();
            label5 = new Label();
            label2 = new Label();
            StdIDTB = new TextBox();
            label1 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ClearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ScoreDataView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // searchTB
            // 
            searchTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTB.Location = new Point(668, 66);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(127, 27);
            searchTB.TabIndex = 70;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.White;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.FromArgb(128, 0, 33);
            SearchBtn.Location = new Point(809, 60);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(110, 36);
            SearchBtn.TabIndex = 69;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ScoreDataView
            // 
            ScoreDataView.AllowUserToAddRows = false;
            ScoreDataView.AllowUserToDeleteRows = false;
            ScoreDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScoreDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScoreDataView.Location = new Point(12, 104);
            ScoreDataView.Name = "ScoreDataView";
            ScoreDataView.RowTemplate.Height = 80;
            ScoreDataView.Size = new Size(910, 283);
            ScoreDataView.TabIndex = 66;
            ScoreDataView.Click += ScoreDataView_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(128, 0, 33);
            panel3.Location = new Point(12, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 10);
            panel3.TabIndex = 67;
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
            panel1.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(399, 15);
            label7.Name = "label7";
            label7.Size = new Size(142, 24);
            label7.TabIndex = 1;
            label7.Text = "Manage Score";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(SelectCourseCB);
            panel2.Controls.Add(DescTB);
            panel2.Controls.Add(ScoreTB);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(StdIDTB);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(ClearBtn);
            panel2.Location = new Point(11, 393);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 220);
            panel2.TabIndex = 71;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 0, 33);
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 102;
            label3.Text = "Select Course : ";
            // 
            // SelectCourseCB
            // 
            SelectCourseCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectCourseCB.FormattingEnabled = true;
            SelectCourseCB.Location = new Point(134, 72);
            SelectCourseCB.Name = "SelectCourseCB";
            SelectCourseCB.Size = new Size(384, 26);
            SelectCourseCB.TabIndex = 101;
            // 
            // DescTB
            // 
            DescTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DescTB.Location = new Point(134, 154);
            DescTB.Multiline = true;
            DescTB.Name = "DescTB";
            DescTB.Size = new Size(384, 54);
            DescTB.TabIndex = 100;
            // 
            // ScoreTB
            // 
            ScoreTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ScoreTB.Location = new Point(134, 111);
            ScoreTB.Name = "ScoreTB";
            ScoreTB.Size = new Size(128, 27);
            ScoreTB.TabIndex = 99;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(27, 157);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 98;
            label5.Text = "Description :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 0, 33);
            label2.Location = new Point(65, 115);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 97;
            label2.Text = "Score : ";
            // 
            // StdIDTB
            // 
            StdIDTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StdIDTB.Location = new Point(134, 20);
            StdIDTB.Name = "StdIDTB";
            StdIDTB.Size = new Size(384, 27);
            StdIDTB.TabIndex = 96;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 95;
            label1.Text = "Student Id : ";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.None;
            UpdateBtn.BackColor = Color.FromArgb(251, 210, 208);
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.FromArgb(128, 0, 33);
            UpdateBtn.Location = new Point(666, 166);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(110, 36);
            UpdateBtn.TabIndex = 89;
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
            DeleteBtn.Location = new Point(782, 166);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(110, 36);
            DeleteBtn.TabIndex = 88;
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
            ClearBtn.Location = new Point(545, 166);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(110, 36);
            ClearBtn.TabIndex = 87;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel2);
            Controls.Add(searchTB);
            Controls.Add(SearchBtn);
            Controls.Add(ScoreDataView);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageScoreForm";
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)ScoreDataView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTB;
        private Button SearchBtn;
        private DataGridView ScoreDataView;
        private Panel panel3;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ClearBtn;
        private Label label3;
        private ComboBox SelectCourseCB;
        private TextBox DescTB;
        private TextBox ScoreTB;
        private Label label5;
        private Label label2;
        private TextBox StdIDTB;
        private Label label1;
    }
}