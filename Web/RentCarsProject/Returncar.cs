using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Returncar
    {
        public int Idreturncar { get; set; }
        public string Condition { get; set; }
        public DateTime Returndate { get; set; }
        public int Idcar { get; set; }
        public int? CarIdcar { get; set; }

        public virtual Car CarIdcarNavigation { get; set; }
    }
}
