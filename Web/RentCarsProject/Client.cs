using System;
using System.Collections.Generic;

#nullable disable

namespace RentCarsProject
{
    public partial class Client
    {
        public Client()
        {
            Fines = new HashSet<Fine>();
            Rentcars = new HashSet<Rentcar>();
        }

        public int Idclient { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Familyname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Passportdata { get; set; }
        public int Driverslicense { get; set; }
        public string Numberofphone { get; set; }
        public int Idbonussystem { get; set; }
        public int? BonussystemIdbonussystem { get; set; }

        public virtual Bonussystem BonussystemIdbonussystemNavigation { get; set; }
        public virtual ICollection<Fine> Fines { get; set; }
        public virtual ICollection<Rentcar> Rentcars { get; set; }
    }
}
