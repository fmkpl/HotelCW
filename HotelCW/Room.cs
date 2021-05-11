using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotelCW
{
    public class Room
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public virtual Admin roomAdmin { get; set; }


        public string Type { get; set; }


        [MaxLength(4, ErrorMessage = "Too larger number of room.")] 
        [MinLength(3, ErrorMessage = "Too short number of room.")]
        [Required(ErrorMessage = "This field is required.")]
        public string Number { get; set; }



        public string Status { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        public int? Price { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
