using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Fine
    {
        public int Idfine { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime Datefine { get; set; }
        public string Status { get; set; }
        public int Idclient { get; set; }
        public int? ClientIdclient { get; set; }

        public virtual Client ClientIdclientNavigation { get; set; }
    }
}
