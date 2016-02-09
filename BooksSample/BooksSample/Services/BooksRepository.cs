using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Services
{
    public class BooksRepository
    {
        public Book GetTheBook() => new Book { Title = "Professional C# 5.0", Publisher = "Wrox Press", Isbn = "347754" };

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book("Professional C# 5.0", "Wrox Press", "838484", "Christian Nagel", "Morgan Skinner", "Jay Glynn"),
                new Book("Professional C# 6", "Wrox Press", "834344", "Christian Nagel"),
                new Book("Enterprise Services", "Addison Wesley", "34774", "Christian Nagel"),
                new Book("Beginning Visual C# 2012", "Wrox Press", "8438348", "Karli Watson", "Christian Nagel")
                //new Book { Title = "Professional C# 5.0", Publisher = "Wrox Press", Isbn = "347754" },
                //new Book {Title = "Enterprise Services", Publisher = "Addison Wesley", Isbn = "7347843" },
                //new Book {Title = "Beginning Visual C# 2012", Publisher = "Wrox Press", Isbn = "37474" }
            };
    }
}
