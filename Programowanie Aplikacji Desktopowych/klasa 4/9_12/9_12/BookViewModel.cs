using CommunityToolkit.Mvvm.ComponentModel;

namespace _9_12
{
    public partial class BookViewModel : ObservableObject
    {
        [ObservableProperty]
        private string tytul;

        [ObservableProperty]
        private string autor;
    }
}
