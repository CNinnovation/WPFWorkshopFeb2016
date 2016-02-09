﻿using BooksSample.Models;
using BooksSample.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book _theBook;

        private ObservableCollection<Book> _books;
        public MainWindow()
        {
            InitializeComponent();
            // _theBook = new BooksRepository().GetTheBook();
            _books = new ObservableCollection<Book>(new BooksRepository().GetBooks());
            //            this.DataContext = _theBook;

            this.DataContext = _books;
        }

        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_theBook.Title, _theBook.Publisher);
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            _theBook.Title = "Professional C# 6 and .NET Core 1.0";
            _theBook.Publisher = "Wiley";
        }

        private void OnAddBook(object sender, RoutedEventArgs e)
        {
            _books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox Press", Isbn = "8348489" });
        }
    }
}
