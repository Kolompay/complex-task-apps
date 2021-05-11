namespace RentCarsProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("locationcar")]
    public partial class locationcar
    {
        public int idlocationcar;
        public string address;
        public string terrain;

        public locationcar(int idlocationcar, string address, string terrain)
        {
            try
            {
                IDlocationcar = idlocationcar;
                Address = address;
                Terrain = terrain;
            }
            catch { throw; }
        }
        public locationcar()
        {

        }

        [Key]
        public int IDlocationcar
        {
            get => idlocationcar;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код местонахождения автомобиля должен быть положительным!");
                idlocationcar = value;
            }
        }

        [Required]
        [StringLength(100)]
        public string Address
        {
            get => address;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите адрес!");
                if (value.Length > 100)
                    address = value.Substring(0, 100);
                else
                    address = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Terrain
        {
            get => terrain;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите описание местности!");
                if (value.Length > 50)
                    terrain = value.Substring(0, 50);
                else
                    terrain = value;
            }
        }

        public virtual ICollection<car> car { get; set; }
    }
}
