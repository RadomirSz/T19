namespace RezerwacjaSal
{
    public class InMemoryRoomRepository : IRoomRepository
    {
        private readonly List<Room> _rooms =
        [
            new Room { Name = "Sala A", Capacity = 10 },
            new Room { Name = "Sala B", Capacity = 20 },
            new Room { Name = "Sala C", Capacity = 30 }
        ];

        public IReadOnlyList<Room> GetAll() => _rooms;

        public bool Exists(string roomName) => _rooms.Exists(r => r.Name == roomName);
    }
}
