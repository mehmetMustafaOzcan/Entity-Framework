using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Bussiness
    {
        public static BAContex context = new();
         
        public static bool BookAdd(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return true;
        }
        public static bool BookRemove(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
            return true;
        }
        public static bool AuthorAdd(Autor autor)
        {
            context.Autors.Add(autor);
            context.SaveChanges();
            return true;
        }
        public static bool AutorRemove(Autor autor)
        {
            context.Autors.Remove(autor);
            context.SaveChanges();
            return true;
        }
        public static bool Update()
        {
           
            context.SaveChanges();
            return true;
        }


    }
}
