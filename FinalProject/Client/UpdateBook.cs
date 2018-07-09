using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Client
{
    public partial class UpdateBook : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        private BookLibrary bookLibrary;
        public UpdateBook(BookLibrary book)
        {
            InitializeComponent();

            bookLibrary = book;
            BookTextBox.Text = book.Book;
            AuthorTextBox.Text = book.Author;
            PagesTextBox.Text = book.Pages.ToString();
            RealeseDateTextBox.Text = book.RealeseDate.ToString();
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CheckingFields())
            {
                int pages;
                int.TryParse(PagesTextBox.Text, out pages);
                int realeseDate;
                int.TryParse(RealeseDateTextBox.Text, out realeseDate);
                var book = new BookLibrary
                {
                    Book = BookTextBox.Text,
                    Author = AuthorTextBox.Text,
                    Pages = pages,
                    RealeseDate = realeseDate
                };
                dataAccess.UpdateBook(bookLibrary.UniqueID, book);
                Close();
            }
        }

        private bool CheckingFields()
        {
            int pages;
            int realeseDate;
            if (string.IsNullOrEmpty(BookTextBox.Text))
            {
                MessageBox.Show(@"Невалидна книга", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(AuthorTextBox.Text))
            {
                MessageBox.Show(@"Невалиден автор", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(PagesTextBox.Text) || !int.TryParse(PagesTextBox.Text, out pages))
            {
                MessageBox.Show(@"Невалиден брой страници", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(RealeseDateTextBox.Text) || !int.TryParse(RealeseDateTextBox.Text, out realeseDate))
            {
                MessageBox.Show(@"Невалидена година", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
