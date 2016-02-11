using MVVMSampleLib.Contracts;
using MVVMSampleLib.Models;
using MVVMSampleLib.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMSampleLib.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel(IMessageContract messageContract)
        {
            _books = new ObservableCollection<Book>(new BooksService().GetAllBooks());
            AddBookCommand = new DelegateCommand(OnAddBook);
            _messageContract = messageContract;
        }

        private readonly IMessageContract _messageContract;

        private readonly ObservableCollection<Book> _books;

        public IEnumerable<Book> Books
        {
            get { return _books; }
        }

        public ICommand AddBookCommand { get; }

        public void OnAddBook()
        {
            _messageContract.ShowMessage("Adding a book");
            _books.Add(new Book { Title = "enter something here", Publisher = "enter something here" });
        }

    }
}
