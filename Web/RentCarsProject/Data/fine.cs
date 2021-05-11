namespace RentCarsProject.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("fine")]
    public partial class fine
    {
        private int idfine;
        private string description;
        private decimal cost;
        private DateTime datefine;
        private string status;
        private int idclient;
        public fine(int idfine, string description, decimal cost, DateTime datefine, string status, int idclient)
        {
            try
            {
                IDfine = idfine;
                Description = description;
                Cost = cost;
                Datefine = datefine;
                Status = status;
                IDclient = idclient;
            }
            catch { throw; }
        }
        public fine()
        {

        }

        [Key]
        public int IDfine
        {
            get => idfine;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код штрафа должен быть положительным!");
                idfine = value;
            }
        }

        [Required]
        [StringLength(70)]
        public string Description
        {
            get => description;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите описание штрафа!");
                if (value.Length > 70)
                    description = value.Substring(0, 70);
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
                    throw new ArgumentException($"Стоимость штрафа должна быть положительной!");
                cost = value;
            }
        }

        public DateTime Datefine
        {
            get => datefine;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException($"Дата штрафа не может быть позднее текущей даты!");
                datefine = value;
            }
        }

        [Required]
        [StringLength(10)]
        public string Status
        {
            get => status;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите статус штрафа!");
                if (value.Length > 10)
                    status = value.Substring(0, 10);
                else
                    status = value;
            }
        }
        public int IDclient
        {
            get => idclient;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код клиента должен быть положительным!");
                idclient = value;
            }
        }

        public virtual client client { get; set; }
    }
}
