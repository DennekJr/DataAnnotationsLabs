using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Name must be between 3 -25 characters")]
        public string FirstName { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Name must be between 3 - 25 Characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        public Room? Room { get; set; }

        public int? RoomId { get; set; }
        public Hotel? Hotel { get; set; }

        public int? HotelId { get; set; }

    }
}
