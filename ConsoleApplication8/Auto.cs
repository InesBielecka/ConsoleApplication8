using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Auto
    {
        protected int _cena = 10000;

        public string Marka { set; get; }
        public enum Marki
        {
            Audi,
            Citroen,
            Dacia,
            Daewoo,
            Dodge,
            Fiat,
            Ford,
            Honda,
            Hyundai,
            Jeep,
            Kia,
            Mazda,
            Mercedes,
            Mitsubishi,
            Nissan,
            Opel,
            Peugeot,
            Renault
        }
        public string Lakier { set; get; }
        public int Rocznik { set; get; }
        public int Przebieg { set; get; }
        public double Silnik { get; set; }
        public bool Klima { get; set; }
        public bool Szyby { get; set; }
        public bool Radio { get; set; }
        public bool Zamek { get; set; }
        public int Cena { get; set; }

        public void JakaMarka()
        {
            Console.WriteLine("Wybierz markę samochodu wpisując przypisaną jej liczbę.");

        }

        public void Paint()
        {
            Console.WriteLine("Jaki kolor lakieru?");

        }

        public void AskForYearOfCarProducion()
        {
            Console.WriteLine("Jaki jest rocznik samochodu? (yyyy)");
        }

        public void AskForMileageOfCar()
        {
            Console.WriteLine("Jaki jest przebieg samochodu?");
        }

        public void AskForEngine()
        {
            Console.WriteLine("Jaką pojemność ma silnik?");
        }

        public void AskForAC()
        {
            Console.WriteLine("Czy samochód posiada klimatyzację? Tak/Nie");
        }

        public void AskForElectricWindows()
        {
            Console.WriteLine("Czy samochód posiada elektrycznie otwierane okna? Tak/Nie");
        }

        public void AskForRadio()
        {
            Console.WriteLine("Czy samochód posiada wbudowane radio? Tak/Nie");
        }

        public void AskForCentralLock()
        {
            Console.WriteLine("Czy samochód posiada centralny zamek? Tak/Nie");
        }

        public bool ChecForAddons()
        {
            bool flag = true;
            bool result = false;
            do
            {
                string AddonInclude = Console.ReadLine().ToUpper();
                switch (AddonInclude)
                {
                    case "TAK":
                        result = true;
                        flag = false;
                        break;
                    case "NIE":
                        flag = false;
                        result = false;
                        break;
                    default:
                        Console.WriteLine("Udziel poprawnej odpowiedzi. Tak/Nie");
                        break;
                }
            } while (flag);
            return result;
        }
        // Rocznik 1980-1990 - 4000, Rocznik 1991-2000 - 3000zł, Rocznik 2001-2007 - 2000zł, Rocznik 2008-2014 - 1000zł,
        // Rocznik 2015 - 2017 + 1000
        // Przebieg 0-30k -500, 30-100k -1000, >100k - 1500
        // Klima tak + 1000
        // Radio tak + 500
        // Szyby tak + 500
        // Zamek tak +500
        public void CountPrice()
        {
            if (Rocznik > 1980 && Rocznik <= 1990)
            {
                _cena -= 4000;
            }
            if (Rocznik > 1990 && Rocznik <= 2000)
            {
                _cena -= 3000;
            }
            if (Rocznik > 2000 && Rocznik <= 2007)
            {
                _cena -= 2000;
            }
            if (Rocznik > 2007 && Rocznik <= 2014)
            {
                _cena -= 1000;
            }
            if (Rocznik > 2014)
            {
                _cena += 1000;
            }
            if (Przebieg > 0 && Przebieg <= 30000)
            {
                _cena -= 500;
            }
            if (Przebieg > 30000 && Przebieg <= 100000)
            {
                _cena -= 1000;
            }
            if (Przebieg > 100000)
            {
                _cena -= 1500;
            }
            if (Klima == true)
            {
                _cena += 1000;
            }
            if (Szyby == true)
            {
                _cena += 500;
            }
            if (Zamek == true)
            {
                _cena += 500;
            }
            if (Radio == true)
            {
                _cena += 500;
            }
            Console.WriteLine("Cena samochodu {0}", _cena);
        }
    }
}
