namespace StudentManagementSystem
{
    partial class ScoreForm
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
            StudentDataView = new DataGridView();
            panel3 = new Panel();
            panel1 = new Panel();
            ShowScoreBtn = new Button();
            ShowStudentBtn = new Button();
            panel2 = new Panel();
            label3 = new Label();
            SelectCourseCB = new ComboBox();
            DescTB = new TextBox();
            ScoreTB = new TextBox();
            AddBtn = new Button();
            ClearBtn = new Button();
            label5 = new Label();
            label2 = new Label();
            StdIDTB = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentDataView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // StudentDataView
            // 
            StudentDataView.AllowUserToAddRows = false;
            StudentDataView.AllowUserToDeleteRows = false;
            StudentDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataView.Location = new Point(12, 53);
            StudentDataView.Name = "StudentDataView";
            StudentDataView.RowTemplate.Height = 80;
            StudentDataView.Size = new Size(911, 313);
            StudentDataView.TabIndex = 43;
            StudentDataView.Click += StudentDataView_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(128, 0, 33);
            panel3.Location = new Point(12, 366);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 10);
            panel3.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 0, 33);
            panel1.Controls.Add(ShowScoreBtn);
            panel1.Controls.Add(ShowStudentBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 52);
            panel1.TabIndex = 42;
            // 
            // ShowScoreBtn
            // 
            ShowScoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ShowScoreBtn.ForeColor = Color.FromArgb(128, 0, 33);
            ShowScoreBtn.Location = new Point(784, 13);
            ShowScoreBtn.Name = "ShowScoreBtn";
            ShowScoreBtn.Size = new Size(129, 32);
            ShowScoreBtn.TabIndex = 1;
            ShowScoreBtn.Text = "Show Score";
            ShowScoreBtn.UseVisualStyleBackColor = true;
            ShowScoreBtn.Click += ShowScoreBtn_Click;
            // 
            // ShowStudentBtn
            // 
            ShowStudentBtn.ForeColor = Color.FromArgb(128, 0, 33);
            ShowStudentBtn.Location = new Point(12, 11);
            ShowStudentBtn.Name = "ShowStudentBtn";
            ShowStudentBtn.Size = new Size(129, 32);
            ShowStudentBtn.TabIndex = 0;
            ShowStudentBtn.Text = "Show Student";
            ShowStudentBtn.UseVisualStyleBackColor = true;
            ShowStudentBtn.Click += ShowStudentBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(SelectCourseCB);
            panel2.Controls.Add(DescTB);
            panel2.Controls.Add(ScoreTB);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(ClearBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(StdIDTB);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 223);
            panel2.TabIndex = 45;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 0, 33);
            label3.Location = new Point(22, 62);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 94;
            label3.Text = "Select Course : ";
            // 
            // SelectCourseCB
            // 
            SelectCourseCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectCourseCB.FormattingEnabled = true;
            SelectCourseCB.Location = new Point(149, 69);
            SelectCourseCB.Name = "SelectCourseCB";
            SelectCourseCB.Size = new Size(414, 26);
            SelectCourseCB.TabIndex = 93;
            // 
            // DescTB
            // 
            DescTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DescTB.Location = new Point(149, 144);
            DescTB.Multiline = true;
            DescTB.Name = "DescTB";
            DescTB.Size = new Size(384, 63);
            DescTB.TabIndex = 92;
            // 
            // ScoreTB
            // 
            ScoreTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ScoreTB.Location = new Point(149, 101);
            ScoreTB.Name = "ScoreTB";
            ScoreTB.Size = new Size(128, 27);
            ScoreTB.TabIndex = 91;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.BackColor = Color.FromArgb(128, 0, 33);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(770, 180);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(110, 36);
            AddBtn.TabIndex = 90;
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
            ClearBtn.Location = new Point(654, 180);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(110, 36);
            ClearBtn.TabIndex = 89;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 0, 33);
            label5.Location = new Point(42, 147);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 88;
            label5.Text = "Description :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 0, 33);
            label2.Location = new Point(80, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 87;
            label2.Text = "Score : ";
            // 
            // StdIDTB
            // 
            StdIDTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StdIDTB.Location = new Point(149, 10);
            StdIDTB.Name = "StdIDTB";
            StdIDTB.Size = new Size(384, 27);
            StdIDTB.TabIndex = 86;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(49, 19);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 85;
            label1.Text = "Student Id : ";
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(panel2);
            Controls.Add(StudentDataView);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView StudentDataView;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private ComboBox SelectCourseCB;
        private TextBox DescTB;
        private TextBox ScoreTB;
        private Button AddBtn;
        private Button ClearBtn;
        private Label label5;
        private Label label2;
        private TextBox StdIDTB;
        private Label label1;
        private Button ShowStudentBtn;
        private Button ShowScoreBtn;
    }
}