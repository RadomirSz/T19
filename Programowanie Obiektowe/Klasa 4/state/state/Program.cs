namespace state;

public interface IDoorState
{
 void PressButton(Door door);
 string Name { get; }
}

public sealed class Door
{
    private IDoorState _state;
    public Door(IDoorState initialState) => _state = initialState;
    public string StateName => _state.Name;
    public void SetState(IDoorState newState) => _state = newState;
    public void PressButton() => _state.PressButton(this);
}

public sealed class OpenState : IDoorState
{
    public string Name => "Open";
    public void PressButton(Door door) => door.SetState(new ClosedState());
}

public sealed class ClosedState : IDoorState
{
    public string Name => "Closed";
    public void PressButton(Door door) => door.SetState(new OpenState());
}

public sealed class LockedState : IDoorState
{
 public string Name => "Locked";
 public void PressButton(Door door)
 {
 // brak reakcji
 }
}

internal class Program
{
 static void Main()
 {
 var door = new Door(new ClosedState());
 Console.WriteLine(door.StateName);

 door.PressButton(); // Closed -> Open
 Console.WriteLine(door.StateName);

 door.PressButton(); // Open -> Closed
 Console.WriteLine(door.StateName);

 door.SetState(new LockedState());
 door.PressButton(); // Locked -> brak reakcji
 Console.WriteLine(door.StateName);
 }
}
