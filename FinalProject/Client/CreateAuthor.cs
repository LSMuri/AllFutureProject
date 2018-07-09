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
    public partial class CreateAuthor : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        public CreateAuthor()
        {
            InitializeComponent();

            BookComboBox.BackColor = Color.Black;
            BookComboBox.ForeColor = Color.White;
            var books = dataAccess.GetBooks();
            BookComboBox.DataSource = books;
            BookComboBox.DisplayMember = "Book";
            BookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CheckingFields())
            {
                var books = (BookLibrary)BookComboBox.SelectedItem;
                int year;
                int.TryParse(YeartextBox.Text, out year);
                var author = new AuthorLibrary
                {
                    Name = AuthortextBox.Text,
                    Gender = GendertextBox.Text,
                    YearOfBirth = year,
                    BookLibrary = books
                };
                dataAccess.CreateAuthor(author);
                Close();
            }
        }
    }
}
