namespace WindowsFormsApp1.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("bonussystem")]
    public partial class Bonussystem
    {
        public int idbonussystem;
        public string description;
        public double discountpercent;

        public Bonussystem(int idbonussystem, string description, double discountpercent)
        {
            try
            {
                IDbonussystem = idbonussystem;
                Description = description;
                Discountpercent = discountpercent;
            }
            catch { throw; }
        }

        [Key]
        public int IDbonussystem
        {
            get => idbonussystem;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код бонуса должен быть положительным!");
                idbonussystem = value;
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
                    throw new ArgumentException($"Введите информацио о скидках и бонусах!");
                if (value.Length > 50)
                    description = value.Substring(0, 50);
                else
                    description = value;
            }
        }

        public double Discountpercent
        {
            get => discountpercent;
            set
            {
                if (value < 0)
                    throw new ArgumentException($"Скидка не может быть отрицательной!");
                discountpercent = value;
            }
        }

        public virtual ICollection<Client> client { get; set; }
    }
}
