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
        public BusinessLayer.PersonLibrary GetPerson(int id)
        {
            using (databases = new FinalProjectEntities())
            {
                var person = databases.PersonLibrary.FirstOrDefault(x => x.id == id);
                if (person != null)
                {
                    return Mapping.ToBussinessPerson(person);
                }
                return null;
            }
        }

        public List<BusinessLayer.PersonLibrary> GetPersons()
        {
            using (databases = new FinalProjectEntities())
            {
                var persons = databases.PersonLibrary.ToList();
                var list = new List<BusinessLayer.PersonLibrary>();

                foreach (var person in persons)
                {
                    list.Add(Mapping.ToBussinessPerson(person));
                }
                return list;
            }
        }

        public void CreatePerson(BusinessLayer.PersonLibrary person)
        {
            using (databases = new FinalProjectEntities())
            {
                var databasePerson = Mapping.ToPersonEntity(person);
                databases.PersonLibrary.Add(databasePerson);
                databases.SaveChanges();
            }
        }

        public void UpdatePerson(int id, BusinessLayer.PersonLibrary person)
        {
            using (databases = new FinalProjectEntities())
            {
                var databasePersons = databases.PersonLibrary.FirstOrDefault(x => x.id == id);
                if (databasePersons != null)
                {
                    databasePersons.BookID = person.BookLibrary.UniqueID;
                    databasePersons.RentedFrom = person.RentedFrom;
                    databasePersons.RentedTo = person.RentedTo;
                    databasePersons.Name = person.Name;
                    databasePersons.IDNumber = person.IDNumber;
                    databasePersons.EGN = person.EGN;
                    databasePersons.Adress = person.Adress;
                    databasePersons.Gender = person.Gender;
                    databasePersons.Phone = person.Phone;
                    databasePersons.email = person.email;

                    databases.SaveChanges();
                }
            }
        }

        public void DeletePerson(int id)
        {
            using (databases = new FinalProjectEntities())
            {
                var person = databases.PersonLibrary.FirstOrDefault(x => x.id == id);
                if (person != null)
                {
                    databases.PersonLibrary.Remove(person);
                }
                databases.SaveChanges();
            }
        }

        public void DeletePerson(BusinessLayer.PersonLibrary person)
        {
            DeletePerson(person.id);
        }
    }
}
