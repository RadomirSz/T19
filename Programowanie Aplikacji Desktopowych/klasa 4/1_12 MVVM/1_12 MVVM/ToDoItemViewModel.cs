using CommunityToolkit.Mvvm.ComponentModel;

namespace _1_12_MVVM
{
    public partial class ToDoItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "";

        [ObservableProperty]
        private bool isCompleted;
    }
}
