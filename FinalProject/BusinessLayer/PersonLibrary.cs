using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonLibrary
    {
        public int id { get; set; }
        public string Name { get; set; }
        public long IDNumber { get; set; }
        public long EGN { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
        public string email { get; set; }
        public string BookName { get { return BookLibrary.Book; } }
        public Nullable<System.DateTime> RentedFrom { get; set; }
        public string RentedTo { get; set; }

        public BookLibrary BookLibrary { get; set; }
    }
}
