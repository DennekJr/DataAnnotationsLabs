namespace DataAnnotations.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Client> Clients { get; set; }

        public Hotel()
        {
            Rooms = new HashSet<Room>();
            Clients = new HashSet<Client>();
        }
    }
}
