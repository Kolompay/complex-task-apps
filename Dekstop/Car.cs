using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Car
    {
        private int idcar;
        private string vinnumber;
        private string brand;
        private string classcar;
        private string name;
        private string transmission;
        private string color;
        private Int16 yearofmanufacture;
        private int idlocationcar;
        public Car(int idcar, string vinnumber, string brand, string classcar, string name, string transmission, string color, Int16 yearofmanufactute, int idlocationcar)
        {
            try
            {
                IDCar = idcar;
                VINnumber = vinnumber;
                Brand = brand;
                ClassCar = classcar;
                Name = name;
                Transmission = transmission;
                Color = color;
                Yearofmanufacture = yearofmanufactute;
                IDlocationcar = idlocationcar;
            }
            catch { throw; }
        }

        public Car(int idcar, string brand, string classcar, string name, string transmission, string color)
        {
            try
            {
                IDCar = idcar;
                Brand = brand;
                ClassCar = classcar;
                Name = name;
                Transmission = transmission;
                Color = color;
            }
            catch { throw; }
        }

        [Key]
        public int IDCar
        {
            get => idcar;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код машины должен быть положительным!");
                idcar = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string VINnumber
        {
            get => vinnumber;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите VIN номер!");
                if (value.Length > 50)
                    vinnumber = value.Substring(0, 50);
                else
                    vinnumber = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Brand
        {
            get => brand;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите бренд автомобиля!");
                if (value.Length > 50)
                    brand = value.Substring(0, 50);
                else
                    brand = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string ClassCar
        {
            get => classcar;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите класс автомобиля!");
                if (value.Length > 50)
                    classcar = value.Substring(0, 50);
                else
                    classcar = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Name
        {
            get => name;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите название автомобиля!");
                if (value.Length > 50)
                    name = value.Substring(0, 50);
                else
                    name = value;
            }
        }

        [Required]
        [StringLength(10)]
        public string Transmission
        {
            get => transmission;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите информацию о коробке передач!");
                if (value.Length > 10)
                    transmission = value.Substring(0, 10);
                else
                    transmission = value;
            }
        }

        [Required]
        [StringLength(30)]
        public string Color
        {
            get => color;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите цвет автомобиля!");
                if (value.Length > 30)
                    color = value.Substring(0, 30);
                else
                    color = value;
            }
        }

        public Int16 Yearofmanufacture
        {
            get => yearofmanufacture;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Год производства автомобиля должен быть положительным!");
                else if (value > DateTime.Now.Year)
                    throw new ArgumentException($"Введенный год производства автомобиля больше чем текущий!");
                yearofmanufacture = value;
            }
        }

        public int IDlocationcar
        {
            get => idlocationcar;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Код локации автомобиля должен быть положительным!");
                idlocationcar = value;
            }
        }
    }
}


