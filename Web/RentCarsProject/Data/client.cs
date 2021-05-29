namespace RentCarsProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("client")]
    public partial class client
    {
        public int idclient;
        public string login;
        public string password;
        public string familyname;
        public string name;
        public string patronymic;
        public int passportdata;
        public int driverslicense;
        public string numberofphone;
        public int idbonussystem;

        public client(int idclient, string login, string passwrod, string familyname, string name, string patronymic, int passportdata, int driverslicense, string numberofphone, int idbonussystem)
        {
            try
            {
                IDclient = idclient;
                Login = login;
                Password = passwrod;
                Familyname = familyname;
                Name = name;
                Patronymic = patronymic;
                Passportdata = passportdata;
                Driverslicense = driverslicense;
                Numberofphone = numberofphone;
                IDbonussystem = idbonussystem;
            }
            catch { throw; }
        }
        public client()
        {

        }

        [Key]
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

        [Required]
        [StringLength(50)]
        public string Login
        {
            get => login;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите логин!");
                if (value.Length > 50)
                    login = value.Substring(0, 50);
                else
                    login = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Password
        {
            get => password;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите пароль!");
                if (value.Length > 50)
                    password = value.Substring(0, 50);
                else
                    password = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Familyname
        {
            get => familyname;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите Фамилию!");
                if (value.Length > 50)
                    familyname = value.Substring(0, 50);
                else
                    familyname = value;
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
                    throw new ArgumentException($"Введите Имя!");
                if (value.Length > 50)
                    name = value.Substring(0, 50);
                else
                    name = value;
            }
        }

        [Required]
        [StringLength(50)]
        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите Отчество!");
                if (value.Length > 50)
                    patronymic = value.Substring(0, 50);
                else
                    patronymic = value;
            }
        }

        public int Passportdata
        {
            get => passportdata;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Введите данные паспорта!");
                passportdata = value;
            }
        }

        public int Driverslicense
        {
            get => driverslicense;
            set
            {
                if (value <= 0)
                    throw new ArgumentException($"Введите номер водительского удостоверения!");
                driverslicense = value;
            }
        }

        [Required]
        [StringLength(20)]
        public string Numberofphone
        {
            get => numberofphone;
            set
            {
                if (value.Length == 0 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Введите номер телефона!");
                if (value.Length > 20)
                    numberofphone = value.Substring(0, 20);
                else
                    numberofphone = value;
            }
        }

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
        public virtual ICollection<fine> fine { get; set; }
        public virtual ICollection<rentcar> rentcar { get; set; }
        public virtual bonussystem bonussystem { get; set; }
    }
}
