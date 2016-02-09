using MySuperCoolFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class Book : BindableBase
    {
        public Book()
        {

        }

        public Book(string title, string publisher, string isbn, params string[] authors)
        {
            _title = title;
            _publisher = publisher;
            Isbn = isbn;
            Authors = new List<string>(authors);
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set { SetProperty(ref _publisher, value); }
        }

        public string Isbn { get; set; }


        public IEnumerable<string> Authors { get; }  // C# 6

        public override string ToString() => Title;  // C# 6 - expression bodied member

        //public override string ToString()
        //{
        //    return Title;
        //}
    }
}
