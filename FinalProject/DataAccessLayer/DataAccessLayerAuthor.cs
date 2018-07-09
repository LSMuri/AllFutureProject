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
        private FinalProjectEntities databases;


        public BusinessLayer.AuthorLibrary GetAuthor(int id)
        {
            using (databases = new FinalProjectEntities())
            {
                var author = databases.AuthorLibrary.FirstOrDefault(x => x.id == id);
                if (author != null)
                {
                    return Mapping.ToBussinessAuthor(author);
                }
                return null;
            }
        }

        public List<BusinessLayer.AuthorLibrary> GetAuthors()
        {
            using (databases = new FinalProjectEntities())
            {
                var authors = databases.AuthorLibrary.ToList();
                var list = new List<BusinessLayer.AuthorLibrary>();

                foreach (var author in authors)
                {
                    list.Add(Mapping.ToBussinessAuthor(author));
                }
                return list;
            }
        }

        public void CreateAuthor(BusinessLayer.AuthorLibrary author)
        {
            using (databases = new FinalProjectEntities())
            {
                var databaseAuthor = Mapping.ToAuthorEntity(author);
                databases.AuthorLibrary.Add(databaseAuthor);
                databases.SaveChanges();
            }
        }

        public void UpdateAuthor(int id, BusinessLayer.AuthorLibrary author)
        {
            using (databases = new FinalProjectEntities())
            {
                var databaseAuthors = databases.AuthorLibrary.FirstOrDefault(x => x.id == id);
                if (databaseAuthors != null)
                {
                    databaseAuthors.BookID = author.BookLibrary.UniqueID;
                    databaseAuthors.Name = author.Name;
                    databaseAuthors.Gender = author.Gender;
                    databaseAuthors.YearOfBirth = author.YearOfBirth;
                    databases.SaveChanges();
                }
            }
        }

        public void DeleteAuthor(int id)
        {
            using (databases = new FinalProjectEntities())
            {
                var author = databases.AuthorLibrary.FirstOrDefault(x => x.id == id);
                if (author != null)
                {
                    databases.AuthorLibrary.Remove(author);
                }
                databases.SaveChanges();
            }
        }

        public void DeleteAuthor(BusinessLayer.AuthorLibrary author)
        {
            DeleteAuthor(author.id);
        }
    }
}

