using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }

        public Client? Client { get; set; }

        public int? CientId { get; set; }
        public Hotel? Hotel { get; set; }
        public int? HotelId {get; set; }
    }
    public enum Section
    {
        First,
        Second,
        Third,
    }
}
