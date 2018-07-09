using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataAccessLayer
{
    public static class Mapping
    {
        public static BusinessLayer.BookLibrary ToBusinessBook(LibraryEntity.BookLibrary databaseBook)
        {
            var bussinessBook = new BusinessLayer.BookLibrary()
            {
                UniqueID = databaseBook.UniqueID,
                Book = databaseBook.Book,
                Author = databaseBook.Author,
                Pages = databaseBook.Pages,
                RealeseDate = databaseBook.RealeseDate
            };
            return bussinessBook;
        }

        public static LibraryEntity.BookLibrary ToBookEntity(BusinessLayer.BookLibrary bussinessBook)
        {
            var databaseBook = new LibraryEntity.BookLibrary()
            {
                UniqueID = bussinessBook.UniqueID,
                Book = bussinessBook.Book,
                Author = bussinessBook.Author,
                Pages = bussinessBook.Pages,
                RealeseDate = bussinessBook.RealeseDate
            };
            return databaseBook;
        }

        public static BusinessLayer.AuthorLibrary ToBussinessAuthor(LibraryEntity.AuthorLibrary databaseAuthor)
        {
            var bussinessAuthor = new BusinessLayer.AuthorLibrary()
            {
                id = databaseAuthor.id,
                Name = databaseAuthor.Name,
                Gender = databaseAuthor.Gender,
                YearOfBirth = databaseAuthor.YearOfBirth,
                BookLibrary = ToBusinessBook(databaseAuthor.BookLibrary)
            };
            return bussinessAuthor;
        }

        public static LibraryEntity.AuthorLibrary ToAuthorEntity(BusinessLayer.AuthorLibrary bussinessAuthor)
        {
            var databaseAuthor = new LibraryEntity.AuthorLibrary()
            {
                id = bussinessAuthor.id,
                Name = bussinessAuthor.Name,
                Gender = bussinessAuthor.Gender,
                YearOfBirth = bussinessAuthor.YearOfBirth,
                BookID = ToBookEntity(bussinessAuthor.BookLibrary).UniqueID
            };
            return databaseAuthor;
        }

        public static BusinessLayer.PersonLibrary ToBussinessPerson(LibraryEntity.PersonLibrary databasePerson)
        {
            var bussinessPerson = new BusinessLayer.PersonLibrary()
            {
                id = databasePerson.id,
                Name = databasePerson.Name,
                IDNumber = databasePerson.IDNumber,
                EGN = databasePerson.EGN,
                Adress = databasePerson.Adress,
                Gender = databasePerson.Gender,
                Phone = databasePerson.Phone,
                email = databasePerson.email,
                RentedFrom = databasePerson.RentedFrom,
                RentedTo = databasePerson.RentedTo,
                BookLibrary = ToBusinessBook(databasePerson.BookLibrary)
            };
            return bussinessPerson;
        }

        public static LibraryEntity.PersonLibrary ToPersonEntity(BusinessLayer.PersonLibrary bussinessPerson)
        {
            var databasePerson = new LibraryEntity.PersonLibrary()
            {
                id = bussinessPerson.id,
                Name = bussinessPerson.Name,
                IDNumber = bussinessPerson.IDNumber,
                EGN = bussinessPerson.EGN,
                Adress = bussinessPerson.Adress,
                Gender = bussinessPerson.Gender,
                Phone = bussinessPerson.Phone,
                email = bussinessPerson.email,
                RentedFrom = bussinessPerson.RentedFrom,
                RentedTo = bussinessPerson.RentedTo,
                BookID = ToBookEntity(bussinessPerson.BookLibrary).UniqueID
            };
            return databasePerson;
        }
    }
}
