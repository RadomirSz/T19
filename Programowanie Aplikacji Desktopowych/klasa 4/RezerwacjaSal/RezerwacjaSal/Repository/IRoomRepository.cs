namespace RezerwacjaSal
{
    public interface IRoomRepository
    {
        IReadOnlyList<Room> GetAll();

        bool Exists(string roomName);
    }
}
