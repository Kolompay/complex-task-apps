using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Locationcar
    {
        public Locationcar()
        {
            Cars = new HashSet<Car>();
        }

        public int Idlocationcar { get; set; }
        public string Address { get; set; }
        public string Terrain { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
