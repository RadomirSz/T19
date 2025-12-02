using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace _2_12_mvvm
{
    public partial class TodoItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private bool isDone;

    }
}
