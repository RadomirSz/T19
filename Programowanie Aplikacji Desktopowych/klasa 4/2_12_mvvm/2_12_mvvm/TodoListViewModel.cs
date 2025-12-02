using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace _2_12_mvvm
{
    public partial class TodoListViewModel : ObservableObject
    {
        public ObservableCollection<TodoItemViewModel> Items { get; } = new();

        [ObservableProperty]
        private string inputText = "";

        public TodoListViewModel()
        {
            Items.Add(new TodoItemViewModel { Text = "Learn MVVM" });
        }

        [RelayCommand]
        private void AddTodo()
        {
            Items.Add(new TodoItemViewModel { Text = InputText});
            InputText = string.Empty;
        }

        [RelayCommand]
        private void RemoveCheckedTodos()
        {
            foreach (var item in Items.Where(item => item.IsDone).ToList())
                Items.Remove(item);
        }

        [RelayCommand]
        private void RemoveTodo(TodoItemViewModel todoItemViewModel)
        {
            Items.Remove(todoItemViewModel);
        }
    }
}
