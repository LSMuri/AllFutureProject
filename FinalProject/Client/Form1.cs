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
    public partial class Form1 : Form
    {
        private DataAccessLayer.DataAccessLayer dataAccess = new DataAccessLayer.DataAccessLayer();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var bookList = dataAccess.GetBooks() ?? new List<BookLibrary>();
            var dataSourceBooks = new BindingList<BookLibrary>(bookList);
            dataBookView.DataSource = dataSourceBooks;

            var authorList = dataAccess.GetAuthors() ?? new List<AuthorLibrary>();
            var dataSourceAuthors = new BindingList<AuthorLibrary>(authorList);
            dataAuthorView.DataSource = dataSourceAuthors;

            var personList = dataAccess.GetPersons() ?? new List<PersonLibrary>();
            var dataSourcePersons = new BindingList<PersonLibrary>(personList);
            dataPersonView.DataSource = dataSourcePersons;
        }

        

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            var dialog = new CreateAuthor();
            dialog.ShowDialog();
            LoadData();
        }

        private void EditAuthor_Click(object sender, EventArgs e)
        {
            var author = (AuthorLibrary)dataAuthorView.SelectedRows[0].DataBoundItem;
            var dialog = new UpdateAuthor(author);
            dialog.ShowDialog();
            LoadData();
        }
        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            if (dataAuthorView.SelectedRows.Count != 0)
            {
                var author = (AuthorLibrary)dataAuthorView.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show(@"Сигурени ли сте, че искате да изриете " + author.Name + @"?",
                    @"Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    dataAccess.DeleteAuthor(author);
                    LoadData();
                }
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            var dialog = new CreateBook();
            dialog.ShowDialog();
            LoadData();
        }

        private void EditBook_Click(object sender, EventArgs e)
        {
            var book = (BookLibrary)dataBookView.SelectedRows[0].DataBoundItem;
            var dialog = new UpdateBook(book);
            dialog.ShowDialog();
            LoadData();
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            if (dataBookView.SelectedRows.Count != 0)
            {
                var books = (BookLibrary)dataBookView.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show(@"Сигурени ли сте, че искате да изриете " + books.Book + @"?",
                    @"Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dataAccess.DeleteBook(books);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show(@"Тази книга не може да бъде изтрита, защото се използва!",
                            @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    LoadData();
                }
            }            
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            var dialog = new CreatePerson();
            dialog.ShowDialog();
            LoadData();
        }


        private void EditPerson_Click(object sender, EventArgs e)
        {
            var person = (PersonLibrary)dataPersonView.SelectedRows[0].DataBoundItem;
            var dialog = new UpdatePerson(person);
            dialog.ShowDialog();
            LoadData();
        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            if (dataPersonView.SelectedRows.Count != 0)
            {
                var person = (PersonLibrary)dataPersonView.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show(@"Сигурени ли сте, че искате да изриете " + person.Name + @"?",
                    @"Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataAccess.DeletePerson(person);
                    LoadData();
                }
            }
        }

              

        private void LoanBook_Click(object sender, EventArgs e)
        {
            var person = (PersonLibrary)dataPersonView.SelectedRows[0].DataBoundItem;
            var dialog = new RentaBook(person);
            dialog.ShowDialog();
            LoadData();
        }

        private void AuthorPage_Click(object sender, EventArgs e)
        {

        }

        private void dataPersonView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataAuthorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
