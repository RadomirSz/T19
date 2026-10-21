import {react, useState} from 'react';

function TodoList(){
    const [todos, setTodos] = useState(
        [
            {id:1,text:"Zrobienie walidacji formularza WPF"},
            {id:2, text:"Podpięcie OnCheckedChangeListener w Androidzie"},
            {id:3,text:"Sprawdzenie statusu w Git"}
        ]);
            
    return (
    <div>
        <h2>Lista zadań</h2>
        <ul>
            {
                todos.map((todo) =>
                    <li key={todo.id}>{todo.text}</li>
                )
            }
        </ul>
    </div>
    );

}
export default TodoList;