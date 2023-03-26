using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Autor
    {
        public int AutorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Book> Books { get;} = new List<Book>();
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
