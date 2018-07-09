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
    public partial class UpdatePerson : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        private PersonLibrary PersonLibrary;
        public UpdatePerson(PersonLibrary person)
        {
            InitializeComponent();

            var books = dataAccess.GetBooks();
            var index = books.Select(x => x.UniqueID).ToList().IndexOf(person.BookLibrary.UniqueID);

            
            BookComboBox.DataSource = books;
            BookComboBox.SelectedIndex = index;
            BookComboBox.DisplayMember = "Book";
            BookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            PersonLibrary = person;
            RentedfromtextBox.Text = person.RentedFrom.ToString();
            RentedtotextBox.Text = person.RentedTo;
            PersontextBox.Text = person.Name;
            AdresstextBox.Text = person.Adress;
            EmailtextBox.Text = person.email;
            GendertextBox.Text = person.Gender;
            IDnumbertextbox.Text = person.IDNumber.ToString();
            EGNtextBox.Text = person.EGN.ToString();
            PhonetextBox.Text = person.Phone.ToString();
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
            if (string.IsNullOrEmpty(IDnumbertextbox.Text) || !long.TryParse(IDnumbertextbox.Text, out idNumber))
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
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CheckingFields())
            {
                long idNumber;
                long egn;
                long phone;
                DateTime rentedfrom;
                DateTime.TryParse(RentedfromtextBox.Text, out rentedfrom);
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
                    RentedTo = RentedtotextBox.Text,
                    RentedFrom = rentedfrom,
                    email = EmailtextBox.Text,
                    BookLibrary = books
                };
                dataAccess.UpdatePerson(PersonLibrary.id,person);
                Close();
            }
        }
    }
}
