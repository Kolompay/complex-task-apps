using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Rate
    {
        public Rate()
        {
            Rentcars = new HashSet<Rentcar>();
        }

        public int Idrate { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int Idcar { get; set; }
        public int? CarIdcar { get; set; }

        public virtual Car CarIdcarNavigation { get; set; }
        public virtual ICollection<Rentcar> Rentcars { get; set; }
    }
}
