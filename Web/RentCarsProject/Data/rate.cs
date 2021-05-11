namespace RentCarsProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("rate")]
    public partial class rate
    {
        public int idrate;
        public string description;
        public decimal cost;
        public int idcar;

        public rate(int idrate, string description, decimal cost, int idcar)
        {
            try
            {
                IDrate = idrate;
                Description = description;
                Cost = cost;
                IDcar = idcar;
            }
            catch { throw; }
        }
        public rate()
        {

        }

        [Key]
        public int IDrate
        {
            get => idrate;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код тарифа должен быть положительным!");
                idrate = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Description
        {
            get => description;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите описание тарифа!");
                if (value.Length > 50)
                    description = value.Substring(0, 50);
                else
                    description = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Стоимость тарифа должна быть положительной!");
                cost = value;
            }
        }

        public int IDcar
        {
            get => idcar;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код машины должен быть положительным!");
                idcar = value;
            }
        }

        public virtual ICollection<rentcar> rentcar { get; set; }
        public virtual car car { get; set; }
    }
}
