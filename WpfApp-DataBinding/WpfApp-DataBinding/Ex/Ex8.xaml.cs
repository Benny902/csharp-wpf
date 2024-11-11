using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WpfApp2_DataBinding1.Ex
{
    /// <summary>
    /// Interaction logic for Ex8.xaml
    /// </summary>

    // Book class definition
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }

    public partial class Ex8 : UserControl, INotifyPropertyChanged
    {
        private Book selectedBook;
        public Book SelectedBook
        {
            get => selectedBook;
            set
            {
                selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public ObservableCollection<Book> Books { get; set; }

        public Ex8()
        {
            InitializeComponent();
            Books = new ObservableCollection<Book>
            {
                new Book { Title = "Book A", Author = "Benny A", Description = "Description for A" },
                new Book { Title = "Book B", Author = "Benny B", Description = "Description for B" },
                new Book { Title = "Book C", Author = "Benny C", Description = "Description for C" }
            };

            DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
