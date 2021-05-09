using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class Room
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public virtual Admin roomAdmin { get; set; }


        public string Type { get; set; }
        public string Number { get; set; }
        public int? Price { get; set; } 

        public virtual ICollection<User> Users { get; set; }
    }
}
