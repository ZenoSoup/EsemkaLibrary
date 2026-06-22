using EsemkaLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLibrary
{
    public partial class BorrowingForm : Form
    {
        public class BooksDataTable
        {
            public int Id { get; set; }
            public string Title { get; set; } = null!;
            public string Genres { get; set; } = null!;
            public string Author { get; set; } = null!;
            public string PublishDate { get; set; } = null!;
            public int Stock { get; set; }
            public string Action { get; set; } = null!;
        }

        int memberId = -1;

        public BorrowingForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void BorrowingForm_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            dgvBook.Rows.Clear();

            string searchText = tbTitle.Text.Trim();

            var books = Repo.db.Books
                       .Where(b => string.IsNullOrEmpty(searchText) || b.Title.Contains(searchText))
                       .ToList()
                       .Select(b => new BooksDataTable
                       {
                           Id = b.Id,
                           Title = b.Title,
                           Genres = string.Join(", ", Repo.db.BookGenres
                                                      .Where(g => g.BookId == b.Id)
                                                      .Select(g => g.Genre.Name)
                                                      .ToList()),
                           Author = b.Author,
                           Stock = b.Stock,
                           PublishDate = b.PublishDate != null 
                                         ? b.PublishDate.Value.ToDateTime(TimeOnly.MinValue).ToString("dd MMMM yyyy")
                                         : "",
                           Action = "Borrow"
                       }).ToList();

            foreach (var book in books)
            {
                int rowIndex = dgvBook.Rows.Add();
                var row = dgvBook.Rows[rowIndex];

                if (book.Stock == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

                row.Cells["id"].Value = book.Id;
                row.Cells["title"].Value = book.Title;
                row.Cells["genre"].Value = book.Genres;
                row.Cells["author"].Value = book.Author;
                row.Cells["publishDate"].Value = book.PublishDate;
                row.Cells["stock"].Value = book.Stock;
                row.Cells["action"].Value = book.Stock > 0 ? book.Action : string.Empty;
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex < 0) return;

            if (columnIndex == 6)
            {
                var row = dgvBook.Rows[rowIndex];

                var book = Repo.db.Books.Find(Convert.ToInt32(row.Cells["id"].Value));

                if (book == null)
                {
                    MessageBox.Show("Book not found");
                    return;
                }

                Borrowing borrowing = new Borrowing
                {
                    MemberId = memberId,
                    BookId = book.Id,
                    BorrowDate = DateTime.Now,
                    ReturnDate = null,
                    Fine = null,
                    CreatedAt = DateTime.Now,
                    DeletedAt = null
                };

                book.Stock--;
                Repo.db.Borrowings.Add(borrowing);
                Repo.db.SaveChanges();

                MessageBox.Show($"Success borrow \"{book.Title}.\"\n" +
                                $"Due date is 7 days from today", "Notification");

                this.Close();
            }
        }
    }
}