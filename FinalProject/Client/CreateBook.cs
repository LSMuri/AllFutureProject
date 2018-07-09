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
    public partial class CreateBook : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        public CreateBook()
        {
            InitializeComponent();
        }

        private bool CheckingFields()
        {
            int pages;
            int realeseDate;
            if (string.IsNullOrEmpty(BooktextBox.Text))
            {
                MessageBox.Show(@"Невалидна книга", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(AuthortextBox.Text))
            {
                MessageBox.Show(@"Невалиден автор", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(PagesBox.Text) || !int.TryParse(PagesBox.Text, out pages))
            {
                MessageBox.Show(@"Невалиден брой страници", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(RealeseDatetextBox.Text) || !int.TryParse(RealeseDatetextBox.Text, out realeseDate))
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
                int pages;
                int.TryParse(PagesBox.Text, out pages);
                int realeseDate;
                int.TryParse(RealeseDatetextBox.Text, out realeseDate);
                var book = new BookLibrary
                {
                    Book = BooktextBox.Text,
                    Author = AuthortextBox.Text,
                    Pages = pages,
                    RealeseDate = realeseDate
                };
                dataAccess.CreateBook(book);               
                Close();
            }
        }

        private void CreateBook_Load(object sender, EventArgs e)
        {

        }
    }
}
