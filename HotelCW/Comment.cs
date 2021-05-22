using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotelCW
{
    public class Comment
    {
        public int Id { get; set; }
        public User UserMain { get; set; }

        [Required(ErrorMessage ="Comment can't be empty.")]
        [MinLength(5, ErrorMessage ="Min lenght of comment is 5 symbols")]
        public string Body { get; set; }
    }
}
