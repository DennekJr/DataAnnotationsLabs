using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotations.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        [InverseProperty("ClientNumber")]

        public int CurrentClientId { get; set; }

        public Client CurrentClient { get; set; }
        [InverseProperty("ClientNumber")]

        public int PreviousClientId { get; set; }
        public Client PreviousClient { get; set; }

    }
    public enum Section
    {
        First,
        Second,
        Third,
    }
}
