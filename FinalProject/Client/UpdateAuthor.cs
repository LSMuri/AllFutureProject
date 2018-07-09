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
    public partial class UpdateAuthor : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        private AuthorLibrary authorLibrary;
        public UpdateAuthor(AuthorLibrary author)
        {
            InitializeComponent();

            authorLibrary = author;
            AuthortextBox.Text = author.Name;
            GendertextBox.Text = author.Gender;
            YeartextBox.Text = author.YearOfBirth.ToString();

            var books = dataAccess.GetBooks();
            var index = books.Select(x => x.UniqueID).ToList().IndexOf(author.BookLibrary.UniqueID);
            BookComboBox.BackColor = Color.Black;
            BookComboBox.ForeColor = Color.White;
            BookComboBox.DataSource = books;
            BookComboBox.SelectedIndex = index;
            BookComboBox.DisplayMember = "Book";
            BookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CheckingFields())
            {
                int years;
                int.TryParse(YeartextBox.Text, out years);
                var books = (BookLibrary)BookComboBox.SelectedItem;
                var author = new AuthorLibrary
                {
                    Name = AuthortextBox.Text,
                    Gender = GendertextBox.Text,
                    YearOfBirth = years,                    
                    BookLibrary = books
                };
                dataAccess.UpdateAuthor(authorLibrary.id, author);
                Close();
            }
        }

        private bool CheckingFields()
        {
            int year;
            if (string.IsNullOrEmpty(GendertextBox.Text))
            {
                MessageBox.Show(@"Невалиден пол", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(AuthortextBox.Text))
            {
                MessageBox.Show(@"Невалиден автор", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(YeartextBox.Text) || !int.TryParse(YeartextBox.Text, out year))
            {
                MessageBox.Show(@"Невалидена година", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
