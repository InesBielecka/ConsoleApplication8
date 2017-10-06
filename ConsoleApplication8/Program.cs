using ConsoleApplication8;
using System;
using System.Linq;
using static ConsoleApplication8.Auto;

class Program
{
    public static void Main()
    {
        bool flag = true;

        Auto auto = new Auto();
        auto.JakaMarka();
        string[] Names = Enum.GetNames(typeof(Marki));
        int[] Values = (int[])Enum.GetValues(typeof(Marki));

        for (int v = 0; v < Names.Length; v++)
        {
            Console.WriteLine("{0} - {1}", Values[v], Names[v]);
        }
        do
        {
            string ChosenBrand = Console.ReadLine();

            int brandIndex = 0;

            if (int.TryParse(ChosenBrand, out brandIndex) && brandIndex >= 0 && brandIndex <= Values.Length)
            {
                auto.Marka = ChosenBrand;
                flag = false;
                auto.Marka = Names[brandIndex];
            }
            else
            {
                Console.WriteLine("Wpisz poprawny numer.");
            }
        }
        while (flag);
       
            
       

        auto.Paint();
        string Paintcolour = Console.ReadLine();
        auto.Lakier = Paintcolour;

        auto.AskForYearOfCarProducion();
        bool flag2 = true;
        do
        {
            string YearofProduction = Console.ReadLine();
            int i = 0;

            if (int.TryParse(YearofProduction, out i) && i > 1980 && i <= DateTime.Now.Year)
            {
                auto.Rocznik = i;
                flag2 = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny rocznik. (yyyy)");
            }
        }
        while (flag2);

        auto.AskForMileageOfCar();
        bool flag3 = true;
        do
        {
            string MileageofCar = Console.ReadLine();
            int mile = 0;
            if (int.TryParse(MileageofCar, out mile) && mile > 0)
            {
                auto.Przebieg = mile;
                flag3 = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny przebieg.");
            }
        }
        while (flag3);

        auto.AskForEngine();
        bool flag4 = true;
        do
        {
            string EngineCapacity = Console.ReadLine();
            double capacity = 0;
            if (double.TryParse(EngineCapacity, out capacity) && capacity >= 1)
            {
                auto.Silnik = capacity;
                flag4 = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawną pojemność silnika.");
            }
        }
        while (flag4);

        auto.AskForAC();
        auto.Klima = auto.ChecForAddons();

        auto.AskForElectricWindows();
        auto.Szyby = auto.ChecForAddons();

        auto.AskForRadio();
        auto.Radio = auto.ChecForAddons();

        auto.AskForCentralLock();
        auto.Zamek = auto.ChecForAddons();

    Console.WriteLine("Auto marki {0}, kolor lakieru {1}, samochód wyprodukowany w roku {2}, \nz przebiegiem {3}km, o pojemności silnika {4}. \n\nKlimatyzacja {5} \nElektryczne okna {6} \nRadio {7} \nCentraly zamek {8}", auto.Marka, auto.Lakier, auto.Rocznik, auto.Przebieg, auto.Silnik, auto.Klima ? "Tak" : "Nie", auto.Szyby ? "Tak" : "Nie", auto.Radio ? "Tak" : "Nie", auto.Zamek ? "Tak" : "Nie");
        auto.CountPrice();
        Console.ReadKey();
    }
}

