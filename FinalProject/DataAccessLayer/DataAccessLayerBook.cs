using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEntity;

namespace DataAccessLayer
{
    public partial class DataAccessLayer
    {
        public BusinessLayer.BookLibrary GetBook(int UniqueID)
        {
            using (databases = new FinalProjectEntities())
            {
                var book = databases.BookLibrary.FirstOrDefault(x => x.UniqueID == UniqueID);
                if (book != null)
                {
                    return Mapping.ToBusinessBook(book);
                }
                return null;
            }
        }

        public List<BusinessLayer.BookLibrary> GetBooks()
        {
            using (databases = new FinalProjectEntities())
            {
                var books = databases.BookLibrary.ToList();
                var list = new List<BusinessLayer.BookLibrary>();

                foreach (var book in books)
                {
                    list.Add(Mapping.ToBusinessBook(book));
                }
                return list;
            }
        }

        public void CreateBook(BusinessLayer.BookLibrary book)
        {
            using (databases = new FinalProjectEntities())
            {
                var databaseBook = Mapping.ToBookEntity(book);
                databases.BookLibrary.Add(databaseBook);
                databases.SaveChanges();
            }
        }

        public void UpdateBook(int UniqueID, BusinessLayer.BookLibrary book)
        {
            using (databases = new FinalProjectEntities())
            {
                var databaseBooks = databases.BookLibrary.FirstOrDefault(x => x.UniqueID == UniqueID);
                if (databaseBooks != null)
                {
                    databaseBooks.Book = book.Book;
                    databaseBooks.Author = book.Author;
                    databaseBooks.Pages = book.Pages;
                    databaseBooks.RealeseDate = book.RealeseDate;
                    databases.SaveChanges();
                }
            }
        }

        public void DeleteBook(int UniqueID)
        {
            using (databases = new FinalProjectEntities())
            {
                var book = databases.BookLibrary.FirstOrDefault(x => x.UniqueID == UniqueID);
                if (book != null)
                {
                    databases.BookLibrary.Remove(book);
                }
                databases.SaveChanges();
            }
        }

        public void DeleteBook(BusinessLayer.BookLibrary book)
        {
            DeleteBook(book.UniqueID);
        }
    }
}
