using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookLibrary
    {
        public int UniqueID { get; set; }
        public string Book { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int RealeseDate { get; set; }
    }
}
