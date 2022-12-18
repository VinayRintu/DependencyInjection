using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class MainImpClass
    {
        private readonly ISchoolRepository _schoolRepository;
        public MainImpClass(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public string GetSchoolNames()
        {
            var schoolName = _schoolRepository.GetSchoolName();
            return schoolName;
        }
        public List<Author> GetAllLists()
        {
            var authorList = _schoolRepository.GetAllList();
            return authorList;
        }
        public string GetNameByBooks()
        {
            string bookName = "HR";
            var bookNames = _schoolRepository.GetNameByBook(bookName);
            return bookNames;
        }


        //public string AddCalculation(int a, int b, int c)
        //{

        //}
    }
}
