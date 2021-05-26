using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class User
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public virtual Room userRoom { get; set; }

        [MaxLength(20, ErrorMessage = "Too long name.")]
        [MinLength(1, ErrorMessage = "Too short name.")]
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }


        [MaxLength(20, ErrorMessage = "Too long last name.")]
        [MinLength(1, ErrorMessage = "Too short last name.")]
        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }


        [MaxLength(30, ErrorMessage = "Too long password.")]
        [MinLength(4, ErrorMessage = "Too short password.")]
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        public int? Adults { get; set; }

        public int? ChildsUnderThree { get; set; }

        public int? ServicePrice { get; set; }

        public int? DaysInHotel { get; set; }


        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email adress.")]
        public string Email { get; set; }

    }
}
