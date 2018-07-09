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
    public partial class CreatePerson : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        public CreatePerson()
        {
            InitializeComponent();

            var books = dataAccess.GetBooks();
            BookComboBox.DataSource = books;
            BookComboBox.DisplayMember = "Book";
            BookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CheckingFields())
            {
                long idNumber;
                long egn;
                long phone;
                long.TryParse(IDnumbertextbox.Text, out idNumber);
                long.TryParse(EGNtextBox.Text, out egn);
                long.TryParse(PhonetextBox.Text, out phone);
                var books = (BookLibrary)BookComboBox.SelectedItem;
                var person = new PersonLibrary
                {
                    Name = PersontextBox.Text,
                    IDNumber = idNumber,
                    EGN = egn,
                    Adress = AdresstextBox.Text,
                    Gender = GendertextBox.Text,
                    Phone = phone,
                    RentedTo = null,
                    RentedFrom = null,
                    email = EmailtextBox.Text,
                    BookLibrary = books
                };
                dataAccess.CreatePerson(person);
                Close();
            }
        }

        private bool CheckingFields()
        {
            long idNumber;
            long egn;
            long phone;
            if (string.IsNullOrEmpty(GendertextBox.Text))
            {
                MessageBox.Show(@"Невалиден пол", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(PersontextBox.Text))
            {
                MessageBox.Show(@"Невалидно име", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(AdresstextBox.Text))
            {
                MessageBox.Show(@"Невалиден адрес", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(IDnumbertextbox.Text)|| !long.TryParse(IDnumbertextbox.Text, out idNumber))
            {
                MessageBox.Show(@"Невалиден ЛКН", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(EGNtextBox.Text) || !long.TryParse(EGNtextBox.Text, out egn))
            {
                MessageBox.Show(@"Невалидено ЕГН", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(PhonetextBox.Text) || !long.TryParse(PhonetextBox.Text, out phone))
            {
                MessageBox.Show(@"Невалиден номер", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
