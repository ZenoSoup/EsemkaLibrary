namespace EsemkaLibrary
{
    partial class BorrowingForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            tbTitle = new TextBox();
            btnSearch = new Button();
            dgvBook = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            publishDate = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            action = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(464, 17);
            label1.Name = "label1";
            label1.Size = new Size(222, 38);
            label1.TabIndex = 0;
            label1.Text = "New Borrowing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Book Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(160, 75);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(827, 31);
            tbTitle.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1009, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBook
            // 
            dgvBook.AllowUserToAddRows = false;
            dgvBook.AllowUserToDeleteRows = false;
            dgvBook.AllowUserToOrderColumns = true;
            dgvBook.AllowUserToResizeRows = false;
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Columns.AddRange(new DataGridViewColumn[] { id, title, genre, author, publishDate, stock, action });
            dgvBook.Location = new Point(27, 126);
            dgvBook.Name = "dgvBook";
            dgvBook.ReadOnly = true;
            dgvBook.RowHeadersWidth = 62;
            dgvBook.Size = new Size(1094, 301);
            dgvBook.TabIndex = 4;
            dgvBook.CellContentClick += dgvBook_CellContentClick;
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
            title.HeaderText = "Title";
            title.MinimumWidth = 8;
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // genre
            // 
            genre.HeaderText = "Genre";
            genre.MinimumWidth = 8;
            genre.Name = "genre";
            genre.ReadOnly = true;
            // 
            // author
            // 
            author.HeaderText = "Author";
            author.MinimumWidth = 8;
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // publishDate
            // 
            publishDate.HeaderText = "Publish Date";
            publishDate.MinimumWidth = 8;
            publishDate.Name = "publishDate";
            publishDate.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 8;
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // action
            // 
            action.HeaderText = "Action";
            action.MinimumWidth = 8;
            action.Name = "action";
            action.ReadOnly = true;
            action.Resizable = DataGridViewTriState.True;
            action.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BorrowingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 467);
            Controls.Add(dgvBook);
            Controls.Add(btnSearch);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BorrowingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esemka Library - New Borrowing Form";
            Load += BorrowingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTitle;
        private Button btnSearch;
        private DataGridView dgvBook;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn publishDate;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewLinkColumn action;
    }
}