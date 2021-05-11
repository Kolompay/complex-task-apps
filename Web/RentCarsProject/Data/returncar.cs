namespace RentCarsProject.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("returncar")]
    public partial class returncar
    {
        public int idreturncar;
        public string condition;
        public DateTime returndate;
        public int idcar;

        public returncar(int idreturncar, string condition, DateTime returndate, int idcar)
        {
            try
            {
                IDreturncar = idreturncar;
                Condition = condition;
                Returndate = returndate;
                IDcar = idcar;
            }
            catch { throw; }
        }
        public returncar()
        {

        }

        [Key]
        public int IDreturncar
        {
            get => idreturncar;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код возврата машины должен быть положительным!");
                idreturncar = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Condition
        {
            get => condition;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите состояние возврата машины!");
                if (value.Length > 50)
                    condition = value.Substring(0, 50);
                else
                    condition = value;
            }
        }

        public DateTime Returndate
        {
            get => returndate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException($"Дата возврата не может быть позднее текущей!");
                returndate = value;
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

        public virtual car car { get; set; }
    }
}