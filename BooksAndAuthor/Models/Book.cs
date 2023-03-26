using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; } = null!;
    }
}
