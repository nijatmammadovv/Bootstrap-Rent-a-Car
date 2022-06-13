using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap_Rent_a_Car.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public int CarDoor { get; set; }
        public int Luggage { get; set; }
        public bool Transmission { get; set; }
        public int MinimumAge { get; set; }
    }
}
