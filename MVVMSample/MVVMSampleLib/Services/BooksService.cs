using MVVMSampleLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampleLib.Services
{
    public class BooksService
    {
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>()
            {
                new Book {Title = "Professional C# 6", Publisher = "Wrox Press" },
                new Book {Title = "Enterprise Services", Publisher = "AWL" }
            };
        }
    }
}
