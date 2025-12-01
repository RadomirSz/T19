
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace _1_12_MVVM
{
    public partial class ToDoListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string newText = string.Empty;

        public ObservableCollection<ToDoItemViewModel> todoItems { get; set; } = new();

        public ToDoListViewModel()
        {
            todoItems.Add(new ToDoItemViewModel { Title = "Buy groceries", IsCompleted = false });
            todoItems.Add(new ToDoItemViewModel { Title = "Buy groceries", IsCompleted = false });
        }

        [RelayCommand]
        public void AddToDoItem()
        {
            todoItems.Add(new ToDoItemViewModel { Title = newText, IsCompleted = false });
        }

        [RelayCommand]
        public void RemoveTodos() 
        {
            todoItems.Clear();
        }
    }   
}
