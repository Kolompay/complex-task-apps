namespace RentCarsProject.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("rentcar")]
    public partial class rentcar
    {
        private int idrentcar;
        private DateTime countdaysrent;
        private decimal cost;
        private DateTime dateofissue;
        private int idcar;
        private int idclient;
        private int idrate;

        public rentcar(int idrentcar, DateTime countdaysrent, decimal cost, DateTime dateofissue, int idcar, int idclient, int idrate)
        {
            try
            {
                IDrentcar = idrentcar;
                Countdaysrent = countdaysrent;
                Cost = cost;
                Dateofissue = dateofissue;
                IDcar = idcar;
                IDclient = idclient;
                IDrate = idrate;
            }
            catch { throw; }
        }
        public rentcar()
        {

        }

        [Key]
        public int IDrentcar
        {
            get => idrentcar;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код аренды машины должен быть положительным!");
                idrentcar = value;
            }
        }

        public DateTime Countdaysrent
        {
            get => countdaysrent;
            set => countdaysrent = value;
        }

        public decimal Cost
        {
            get => cost;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Стоимость аренды должна быть положительной!");
                cost = value;
            }
        }

        public DateTime Dateofissue
        {
            get => dateofissue;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException($"Дата начала проката не может быть позднее текущей!");
                dateofissue = value;
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

        public int IDrate
        {
            get => idrate;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код аренды должен быть положительным!");
                idrate = value;
            }
        }

        public virtual car car { get; set; }
        public virtual client client { get; set; }
        public virtual rate rate { get; set; }
    }
}