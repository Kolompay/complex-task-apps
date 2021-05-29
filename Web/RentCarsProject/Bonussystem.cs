using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Bonussystem
    {
        public Bonussystem()
        {
            Clients = new HashSet<Client>();
        }

        public int Idbonussystem { get; set; }
        public string Description { get; set; }
        public double Discountpercent { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
