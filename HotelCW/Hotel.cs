using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class Hotel
    {
        public Hotel()
        {
            Name = "Diamond Plaza";
            listOfRooms = new List<Room>() {
                new Room() { Number="101", Price=100},
                new Room() { Number="201", Price=100},
                /*new Room() { Number="301", Price=100},
                new Room() { Number="401", Price=100},
                new Room() { Number="501", Price=200},
                new Room() { Number="601", Price=350},
                new Room() { Number="701", Price=350},
                new Room() { Number="801", Price=350}*/
            };
        }
        public string Name { get; set; }
        public List<Room> listOfRooms;
    }
}
