using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly IAuthor _db;
        public SchoolRepository(IAuthor db)
        {
            _db = db;
        }
        public string GetSchoolName()
        {
            string schollName = "Hyd Public School";
            return schollName;
        }
        public List<Author> GetAllList()
        {
            var record = _db.DepartmentListMethod();
            return record;
        }
        public string GetNameByBook(string book)
        {
            var bookName = _db.DepartmentListMethod();
            var name = bookName.Where(x => x.Book == book).Select(x => x.Name).FirstOrDefault();
            return book;
        }
    }   
    public class Author : IAuthor
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public double Price { get; set; }

        public List<Author> DepartmentListMethod()
        {
            List<Author> authorList = new List<Author>
            {
                 new Author { Name = "Human Resource", Book = "HR" },
                 new Author { Name = "Electricity", Book = "EC" },
                 new Author { Name = "Home Department", Book = "HD" },
                 new Author { Name = "Health Department", Book = "HL" },
                 new Author { Name = "Finance", Book = "FN" }
            };
            return authorList;
        }
    }
    public interface IAuthor
    {
        List<Author> DepartmentListMethod();
    }
}
