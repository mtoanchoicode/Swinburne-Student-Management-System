namespace StudentManagementSystem
{
    partial class PrintStudent
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
            panel2 = new Panel();
            StudentDataView = new DataGridView();
            SearchBtn = new Button();
            FemaleRB = new RadioButton();
            AllRB = new RadioButton();
            label4 = new Label();
            MaleRb = new RadioButton();
            ClassCB = new ComboBox();
            label1 = new Label();
            PrintBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataView).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplon Norm Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(413, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 24);
            label7.TabIndex = 1;
            label7.Text = "To Print";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(128, 0, 33);
            panel2.Location = new Point(13, 525);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 12);
            panel2.TabIndex = 66;
            // 
            // StudentDataView
            // 
            StudentDataView.AllowUserToAddRows = false;
            StudentDataView.AllowUserToDeleteRows = false;
            StudentDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataView.Location = new Point(13, 116);
            StudentDataView.Margin = new Padding(4);
            StudentDataView.Name = "StudentDataView";
            StudentDataView.RowTemplate.Height = 80;
            StudentDataView.Size = new Size(906, 409);
            StudentDataView.TabIndex = 65;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchBtn.BackColor = Color.FromArgb(128, 0, 33);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(779, 75);
            SearchBtn.Margin = new Padding(4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(125, 33);
            SearchBtn.TabIndex = 67;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // FemaleRB
            // 
            FemaleRB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FemaleRB.AutoSize = true;
            FemaleRB.ForeColor = Color.FromArgb(128, 0, 33);
            FemaleRB.Location = new Point(315, 567);
            FemaleRB.Margin = new Padding(4);
            FemaleRB.Name = "FemaleRB";
            FemaleRB.Size = new Size(77, 22);
            FemaleRB.TabIndex = 70;
            FemaleRB.Text = "Female";
            FemaleRB.UseVisualStyleBackColor = true;
            // 
            // AllRB
            // 
            AllRB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AllRB.AutoSize = true;
            AllRB.Checked = true;
            AllRB.ForeColor = Color.FromArgb(128, 0, 33);
            AllRB.Location = new Point(135, 567);
            AllRB.Margin = new Padding(4);
            AllRB.Name = "AllRB";
            AllRB.Size = new Size(43, 22);
            AllRB.TabIndex = 69;
            AllRB.TabStop = true;
            AllRB.Text = "All";
            AllRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(128, 0, 33);
            label4.Location = new Point(20, 567);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 68;
            label4.Text = "Gender : ";
            // 
            // MaleRb
            // 
            MaleRb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MaleRb.AutoSize = true;
            MaleRb.ForeColor = Color.FromArgb(128, 0, 33);
            MaleRb.Location = new Point(227, 567);
            MaleRb.Margin = new Padding(4);
            MaleRb.Name = "MaleRb";
            MaleRb.Size = new Size(57, 22);
            MaleRb.TabIndex = 71;
            MaleRb.Text = "Male";
            MaleRb.UseVisualStyleBackColor = true;
            // 
            // ClassCB
            // 
            ClassCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClassCB.FormattingEnabled = true;
            ClassCB.Location = new Point(517, 80);
            ClassCB.Margin = new Padding(4);
            ClassCB.Name = "ClassCB";
            ClassCB.Size = new Size(245, 26);
            ClassCB.TabIndex = 72;
            ClassCB.SelectedIndexChanged += ClassCB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 0, 33);
            label1.Location = new Point(405, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 18);
            label1.TabIndex = 73;
            label1.Text = "Select Class: ";
            // 
            // PrintBtn
            // 
            PrintBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PrintBtn.BackColor = Color.FromArgb(128, 0, 33);
            PrintBtn.FlatStyle = FlatStyle.Flat;
            PrintBtn.Font = new Font("Simplon Norm Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(779, 556);
            PrintBtn.Margin = new Padding(4);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(125, 44);
            PrintBtn.TabIndex = 74;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // PrintStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(PrintBtn);
            Controls.Add(label1);
            Controls.Add(ClassCB);
            Controls.Add(MaleRb);
            Controls.Add(FemaleRB);
            Controls.Add(AllRB);
            Controls.Add(label4);
            Controls.Add(SearchBtn);
            Controls.Add(panel2);
            Controls.Add(StudentDataView);
            Controls.Add(panel1);
            Font = new Font("Simplon Norm", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PrintStudent";
            Text = "PrintStudent";
            Load += PrintStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private DataGridView StudentDataView;
        private Button SearchBtn;
        private RadioButton FemaleRB;
        private RadioButton AllRB;
        private Label label4;
        private RadioButton MaleRb;
        private ComboBox ClassCB;
        private Label label1;
        private Button PrintBtn;
    }
}