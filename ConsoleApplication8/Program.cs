using System;
using System.Linq;

public class Auto
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
        Console.WriteLine("Czy samochód posiada klimatyzację? T/N");
    }

    public void AskForElectricWindows()
    {
        Console.WriteLine("Czy samochód posiada elektrycznie otwierane okna? T/N");
    }

}
class Program : Auto
{
    public static void Main()
    {
        bool flag = true;

        Auto m = new Auto();
        m.JakaMarka();
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
                m.Marka = ChosenBrand;
                flag = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny numer.");
            }
        }
        while (flag);

        Auto p = new Auto();
        p.Paint();
        string Paintcolour = Console.ReadLine();
        p.Lakier = Paintcolour;

        Auto y = new Auto();
        y.AskForYearOfCarProducion();
        bool flag2 = true;
        do
        {
            string YearofProduction = Console.ReadLine();
            int i = 0;

            if (int.TryParse(YearofProduction, out i) && i > 1950 && i <= DateTime.Now.Year)
            {
                y.Rocznik = i;
                flag2 = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny rocznik. (yyyy)");
            }
        }
        while (flag2);

        Auto mileage = new Auto();
        mileage.AskForMileageOfCar();
        bool flag3 = true;
        do
        {
            string MileageofCar = Console.ReadLine();
            int mile = 0;
            if (int.TryParse(MileageofCar, out mile) && mile > 0)
            {
                mileage.Przebieg = mile;
                flag3 = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny przebieg.");
            }
        }
        while (flag3);

        Auto engine = new Auto();
        engine.AskForEngine();
        bool flag4 = true;
        do
        {
            string EngineCapacity = Console.ReadLine();
            double capacity = 0;
            if (double.TryParse(EngineCapacity, out capacity) && capacity >= 1)
            {
                engine.Silnik = capacity;
                flag4 = false;
            }
        }
        while (flag4);

        Auto airconditioning = new Auto();
        airconditioning.AskForAC();
        bool flag5 = true;
        do
        {
            string AirConditioningIncluding = Console.ReadLine().ToUpper();
            switch (AirConditioningIncluding)
            {
                case "T":
                    flag5 = false;
                    break;
                case "N":
                    flag5 = false;
                    break;
                default:
                    Console.WriteLine("Udziel poprawnej odpowiedzi. T/N");
                    break;
            }
        }
        while (flag5);

        Auto electricwindows = new Auto();
        electricwindows.AskForElectricWindows();
        bool flag6 = true;
        do
        {
            string ElectricWindowsInclud = Console.ReadLine().ToUpper();
            switch (ElectricWindowsInclud)
            {
                case "T":
                    flag6 = false;
                    break;
                case "N":
                    flag6 = false;
                    break;
                default:
                    Console.WriteLine("Udziel poprawnej odpowiedzi. T/N");
                    break;
            }
        }
        while (flag6);
    }
}


