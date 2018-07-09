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
    public partial class RentaBook : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();

        private PersonLibrary PersonLibrary;
        public RentaBook(PersonLibrary person)
        {
            InitializeComponent();

            var books = dataAccess.GetBooks();
            var index = books.Select(x => x.UniqueID).ToList().IndexOf(person.BookLibrary.UniqueID);
            var bookindex = books.Select(x => x.UniqueID);

            BookComboBox.BackColor = Color.Black;
            BookComboBox.ForeColor = Color.White;
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
            int year;
            int date;
            int month;
            
            
            if (string.IsNullOrEmpty(datetextbox.Text) || !int.TryParse(datetextbox.Text, out date))
            {
                MessageBox.Show(@"Въведете дата", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(monthtextbox.Text) || !int.TryParse(monthtextbox.Text, out month))
            {
                MessageBox.Show(@"Въведете месец", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(yeartextbox.Text) || !int.TryParse(yeartextbox.Text, out year))
            {
                MessageBox.Show(@"Въведете година", @"Опитайте отново", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CheckingFields())
            {
                int date;
                int.TryParse(datetextbox.Text, out date);
                int month;
                int.TryParse(monthtextbox.Text, out month);
                int year;
                int.TryParse(yeartextbox.Text, out year);
                string rentto = ($"{date}.{month}.{year} г.");
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
                    RentedTo = rentto,
                    RentedFrom = DateTime.Now,
                    email = EmailtextBox.Text,
                    BookLibrary = books
                };
                DialogResult dialogResult = MessageBox.Show(@"Натиснете 'Yes' за да добавите още книги , ако искате да продължите натиснете 'No'!!!", "Искате ли да добавите още книги?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dataAccess.CreatePerson(person);
                }
                else if (dialogResult == DialogResult.No)
                {
                    dataAccess.CreatePerson(person);
                    Close();
                }
            }
        }
    }
}
