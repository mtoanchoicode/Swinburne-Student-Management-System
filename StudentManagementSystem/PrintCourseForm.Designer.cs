namespace StudentManagementSystem
{
    partial class PrintCourseForm
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
            PrintBtn = new Button();
            SearchBtn = new Button();
            panel2 = new Panel();
            CourseDataView = new DataGridView();
            panel1 = new Panel();
            searchTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CourseDataView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(374, 20);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(215, 24);
            label7.TabIndex = 1;
            label7.Text = "Swinburne Course List";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PrintBtn
            // 
            PrintBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PrintBtn.BackColor = Color.FromArgb(128, 0, 33);
            PrintBtn.FlatStyle = FlatStyle.Flat;
            PrintBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(779, 562);
            PrintBtn.Margin = new Padding(4);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(125, 44);
            PrintBtn.TabIndex = 85;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.FromArgb(128, 0, 33);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(779, 81);
            SearchBtn.Margin = new Padding(4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(125, 33);
            SearchBtn.TabIndex = 78;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(128, 0, 33);
            panel2.Location = new Point(13, 531);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 12);
            panel2.TabIndex = 77;
            // 
            // CourseDataView
            // 
            CourseDataView.AllowUserToAddRows = false;
            CourseDataView.AllowUserToDeleteRows = false;
            CourseDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CourseDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CourseDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDataView.Location = new Point(13, 122);
            CourseDataView.Margin = new Padding(4);
            CourseDataView.Name = "CourseDataView";
            CourseDataView.RowTemplate.Height = 80;
            CourseDataView.Size = new Size(906, 409);
            CourseDataView.TabIndex = 76;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 0, 33);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 63);
            panel1.TabIndex = 75;
            // 
            // searchTB
            // 
            searchTB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTB.Location = new Point(581, 85);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(191, 27);
            searchTB.TabIndex = 86;
            // 
            // PrintCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(searchTB);
            Controls.Add(PrintBtn);
            Controls.Add(SearchBtn);
            Controls.Add(panel2);
            Controls.Add(CourseDataView);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintCourseForm";
            Text = "PrintCourseForm";
            Load += PrintCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)CourseDataView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button PrintBtn;
        private Button SearchBtn;
        private Panel panel2;
        private DataGridView CourseDataView;
        private Panel panel1;
        private TextBox searchTB;
    }
}