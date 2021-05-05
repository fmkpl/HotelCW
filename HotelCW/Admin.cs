using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class Admin
    {
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string AdminControlword { get; set; }

        public void AcceptRoomReserving() { }
        public void CancelRoomReserving() { }

    }
}
