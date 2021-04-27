using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCW
{
    public class Country
    {
        public string Name { get; set; }
        
        List<Hotel> hotelsInTheCountry = new List<Hotel>();
    }
}
