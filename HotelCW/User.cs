using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Room userRoom { get; set; }

        public DateTime selectedDateFrom { get; set; }
        public DateTime selectedDateTo { get; set; }

        public int Adults { get; set; }
        public int ChildsUnderThree { get; set; }
        public int ServicePrice { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}
