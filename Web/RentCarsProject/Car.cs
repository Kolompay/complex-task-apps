using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Car
    {
        public Car()
        {
            Rates = new HashSet<Rate>();
            Rentcars = new HashSet<Rentcar>();
            Returncars = new HashSet<Returncar>();
        }

        public int Idcar { get; set; }
        public string Vinnumber { get; set; }
        public string Brand { get; set; }
        public string ClassCar { get; set; }
        public string Name { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public short Yearofmanufacture { get; set; }
        public int Idlocationcar { get; set; }
        public int? LocationcarIdlocationcar { get; set; }

        public virtual Locationcar LocationcarIdlocationcarNavigation { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Rentcar> Rentcars { get; set; }
        public virtual ICollection<Returncar> Returncars { get; set; }
    }
}
