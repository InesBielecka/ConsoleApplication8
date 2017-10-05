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
    }
}
