using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Rentcar
    {
        public int Idrentcar { get; set; }
        public DateTime Countdaysrent { get; set; }
        public decimal Cost { get; set; }
        public DateTime Dateofissue { get; set; }
        public int Idcar { get; set; }
        public int Idclient { get; set; }
        public int Idrate { get; set; }
        public int? CarIdcar { get; set; }
        public int? ClientIdclient { get; set; }
        public int? RateIdrate { get; set; }

        public virtual Car CarIdcarNavigation { get; set; }
        public virtual Client ClientIdclientNavigation { get; set; }
        public virtual Rate RateIdrateNavigation { get; set; }
    }
}
