using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentleBookStore.Models;

namespace WebGentleBookStore.Repository
{
    public class BookRepositoty
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Title.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Vinay"},
                new BookModel(){Id=1,Title="ASP.NET",Author="Singh"},
                new BookModel(){Id=1,Title="WEB API",Author="Ravi"},
                new BookModel(){Id=1,Title="SQL",Author="kavi"},
                new BookModel(){Id=1,Title="DOCKER",Author="Sheety"}
            };
        }
    }
}
