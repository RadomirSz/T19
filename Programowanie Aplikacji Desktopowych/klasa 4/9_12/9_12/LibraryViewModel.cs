using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    public partial class LibraryViewModel : ObservableObject
    {

        public ObservableCollection<BookViewModel> Books { get; } = new();

        public LibraryViewModel()
        {
            Books.Add(new BookViewModel { Tytul = "Dziady", Autor = "Adam Mickiewicz" });
            Books.Add(new BookViewModel { Tytul = "Pan Tadeusz", Autor = "Adam Mickiewicz" });
            Books.Add(new BookViewModel { Tytul = "Pan Mickiewicz", Autor = "Adam Tadeusz" });
        }
    }
}
