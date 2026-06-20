using EsemkaLibrary.Model;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace EsemkaLibrary
{
    public partial class MainForm : Form
    {
        public class DataBorrowingTable
        {
            public int Id { get; set; }
            public string Title { get; set; } = null!;
            public string BorrowDate { get; set; } = null!;
            public string DueDate { get; set; } = null!;
            public int OverdueDays { get; set; }
            public string LinkText { get; set; } = null!;
        }

        int memberId = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer_Tick(sender, e);
            loadTextboxSuggestion();
        }

        private void loadTextboxSuggestion()
        {
            List<string> names = Repo.db.Members
                                     .Select(m => m.Name)
                                     .ToList();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(names.ToArray());

            tbName.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbName.AutoCompleteCustomSource = collection;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter a member name first", "Member name expected");
                return;
            }

            if (!Repo.db.Members.Any(m => m.Name.Contains(tbName.Text)))
            {
                MessageBox.Show("Member doesn't exist", "No member found");
                return;
            }

            var member = Repo.db.Members.FirstOrDefault(m => m.Name.Contains(tbName.Text))!;
            memberId = member.Id;

            MessageBox.Show("Member found");

            loadBorrowingTable();
        }

        private void loadBorrowingTable()
        {
            List<DataBorrowingTable> borrowings = Repo.db.Borrowings
                                                .Where(b => b.MemberId == memberId && b.ReturnDate == null)
                                                .Select(b => new DataBorrowingTable
                                                {
                                                    Id = b.Id,
                                                    Title = b.Book.Title,
                                                    BorrowDate = b.BorrowDate.ToString("dd MMMM yyyy"),
                                                    DueDate = b.BorrowDate.AddDays(7).ToString("dd MMMM yyyy"),
                                                    OverdueDays = (DateTime.Now - b.BorrowDate.AddDays(7)).Days,
                                                    LinkText = "return"
                                                }).ToList();

            dgvBorrowing.Rows.Clear();

            if (borrowings.Count <= 0)
            {
                btnNewBorrowing.Enabled = true;
                return;
            }

            dgvBorrowing.Rows.Add(borrowings.Count);

            int i = 0;

            foreach (var borrow in borrowings)
            {
                if (borrow.OverdueDays < 0)
                {
                    borrow.OverdueDays = 0;
                    dgvBorrowing.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

                else if (borrow.OverdueDays == 0)
                {
                    dgvBorrowing.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }

                else
                {
                    dgvBorrowing.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }

                dgvBorrowing.Rows[i].Cells["id"].Value = borrow.Id;
                dgvBorrowing.Rows[i].Cells["title"].Value = borrow.Title;
                dgvBorrowing.Rows[i].Cells["borrowDate"].Value = borrow.BorrowDate;
                dgvBorrowing.Rows[i].Cells["dueDate"].Value = borrow.DueDate;
                dgvBorrowing.Rows[i].Cells["overdueDays"].Value = borrow.OverdueDays.ToString();
                dgvBorrowing.Rows[i].Cells["action"].Value = borrow.LinkText;

                i++;
            }

            if (borrowings.Count >= 3)
            {
                btnNewBorrowing.Enabled = false;
            }
            else
            {
                btnNewBorrowing.Enabled = true;
            }
        }

        private void dgvBorrowing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex < 0)
            {
                return;
            }

            if (columnIndex == 5)
            {
                var row = dgvBorrowing.Rows[rowIndex];

                var borrowing = Repo.db.Borrowings
                                .Find(Convert.ToInt32(row.Cells["id"].Value));

                if (borrowing == null)
                {
                    MessageBox.Show("Borrowing data not found");
                    return;
                }

                var book = Repo.db.Books
                           .FirstOrDefault(b => borrowing.BookId == b.Id)!;

                book.Stock++;
                borrowing.ReturnDate = DateTime.Now;

                if (Convert.ToInt32(row.Cells["overdueDays"].Value) > 0)
                {
                    int fine = Convert.ToInt32(row.Cells["overdueDays"].Value) * 2000;
                    MessageBox.Show($"Success return \"{book.Title}\" \nMember needs to pay fine: {fine} IDR");
                    borrowing.Fine = fine;
                }

                else
                {
                    MessageBox.Show($"Success return \"{book.Title}\"");
                }

                Repo.db.SaveChanges();

                loadBorrowingTable();
            }
        }

        private void btnNewBorrowing_Click(object sender, EventArgs e)
        {
            Form borrowingForm = new BorrowingForm(memberId);

            this.Hide();

            borrowingForm.Show();

            borrowingForm.FormClosed += (s, args) =>
            {
                this.Show();
                loadBorrowingTable();
            };
        }
    }
}
