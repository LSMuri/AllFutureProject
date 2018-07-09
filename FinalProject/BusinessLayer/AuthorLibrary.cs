using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AuthorLibrary
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int YearOfBirth { get; set; }
        public string BookName { get { return BookLibrary.Book; } }

        public BookLibrary BookLibrary { get; set; }
    }
}
