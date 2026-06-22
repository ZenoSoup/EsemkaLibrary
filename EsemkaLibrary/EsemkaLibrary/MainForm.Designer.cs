namespace EsemkaLibrary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            tbName = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvBorrowing = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            borrowDate = new DataGridViewTextBoxColumn();
            dueDate = new DataGridViewTextBoxColumn();
            overdueDays = new DataGridViewTextBoxColumn();
            Action = new DataGridViewLinkColumn();
            btnNewBorrowing = new Button();
            lblTime = new Label();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowing).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 0;
            label1.Text = "ESEMKA Library Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 46);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(770, 75);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Member Data";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(638, 31);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 20);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(78, 30);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(542, 25);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvBorrowing);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(19, 124);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(770, 153);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrowing Data";
            // 
            // dgvBorrowing
            // 
            dgvBorrowing.AllowUserToAddRows = false;
            dgvBorrowing.AllowUserToDeleteRows = false;
            dgvBorrowing.AllowUserToOrderColumns = true;
            dgvBorrowing.AllowUserToResizeRows = false;
            dgvBorrowing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowing.Columns.AddRange(new DataGridViewColumn[] { id, title, borrowDate, dueDate, overdueDays, Action });
            dgvBorrowing.Location = new Point(17, 26);
            dgvBorrowing.Margin = new Padding(2);
            dgvBorrowing.Name = "dgvBorrowing";
            dgvBorrowing.ReadOnly = true;
            dgvBorrowing.RowHeadersWidth = 62;
            dgvBorrowing.Size = new Size(749, 115);
            dgvBorrowing.TabIndex = 0;
            dgvBorrowing.CellContentClick += dgvBorrowing_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // title
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            title.DefaultCellStyle = dataGridViewCellStyle1;
            title.HeaderText = "Title";
            title.MinimumWidth = 10;
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // borrowDate
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            borrowDate.DefaultCellStyle = dataGridViewCellStyle2;
            borrowDate.HeaderText = "Borrow Date";
            borrowDate.MinimumWidth = 8;
            borrowDate.Name = "borrowDate";
            borrowDate.ReadOnly = true;
            // 
            // dueDate
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dueDate.DefaultCellStyle = dataGridViewCellStyle3;
            dueDate.HeaderText = "Due Date";
            dueDate.MinimumWidth = 8;
            dueDate.Name = "dueDate";
            dueDate.ReadOnly = true;
            // 
            // overdueDays
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            overdueDays.DefaultCellStyle = dataGridViewCellStyle4;
            overdueDays.HeaderText = "Overdue Day(s)";
            overdueDays.MinimumWidth = 8;
            overdueDays.Name = "overdueDays";
            overdueDays.ReadOnly = true;
            // 
            // Action
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Action.DefaultCellStyle = dataGridViewCellStyle5;
            Action.HeaderText = "Action";
            Action.MinimumWidth = 8;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "";
            // 
            // btnNewBorrowing
            // 
            btnNewBorrowing.Enabled = false;
            btnNewBorrowing.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewBorrowing.Location = new Point(19, 282);
            btnNewBorrowing.Margin = new Padding(2);
            btnNewBorrowing.Name = "btnNewBorrowing";
            btnNewBorrowing.Size = new Size(171, 24);
            btnNewBorrowing.TabIndex = 3;
            btnNewBorrowing.Text = "New Borrowing";
            btnNewBorrowing.UseVisualStyleBackColor = true;
            btnNewBorrowing.Click += btnNewBorrowing_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(485, 287);
            lblTime.Margin = new Padding(2, 0, 2, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(300, 19);
            lblTime.TabIndex = 4;
            lblTime.Text = "label3";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 324);
            Controls.Add(lblTime);
            Controls.Add(btnNewBorrowing);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESEMKA Library";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox tbName;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvBorrowing;
        private Button btnNewBorrowing;
        private Label lblTime;
        private System.Windows.Forms.Timer timer;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn borrowDate;
        private DataGridViewTextBoxColumn dueDate;
        private DataGridViewTextBoxColumn overdueDays;
        private DataGridViewLinkColumn Action;
    }
}
