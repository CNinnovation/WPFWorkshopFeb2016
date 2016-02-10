using BooksSample.Models;
using BooksSample.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book _theBook = null;

        private ObservableCollection<Book> _books;
        public MainWindow()
        {
            InitializeComponent();
             _theBook = new BooksRepository().GetTheBook();
            _books = new ObservableCollection<Book>(new BooksRepository().GetBooks());
            //            this.DataContext = _theBook;

            this.DataContext = _books;
        }

        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            // CollectionViewSource.GetDefaultView(_books).CurrentItem
            // MessageBox.Show(_theBook.Title, _theBook.Publisher);
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            //_theBook.Title = "Professional C# 6 and .NET Core 1.0";
            //_theBook.Publisher = "Wiley";
            Book book = _books.SingleOrDefault(b => b.Title.Contains("C# 6"));
            if (book != null)
            {
                book.Title = "Professional C# 6 and .NET Core 1.0";
            }
        }

        private void OnAddBook(object sender, RoutedEventArgs e)
        {
            _books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox Press", Isbn = "8348489" });
        }
    }
}
