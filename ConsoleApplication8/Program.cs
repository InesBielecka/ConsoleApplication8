using System;
public abstract class Auto
{
    private string _marka;
    private string _lakier;
    private int _rocznik;
    private int _przebieg;
    private double _silnik;
    private bool _klimatyzacja;
    private bool _autoszyby;
    private bool _radio;
    private bool _centralnyzamek;
    protected int _cena = 10000;

    public string Markaa { set; get; }
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

    public int Rocznik
    {
        set
        {
            if (value < 1980)
            {
                Console.WriteLine("Rocznik samochodu nie może być mniejszy niż 1980.");
            }
            else if (value > DateTime.Now.Year)
            {
                Console.WriteLine("Rocznik samochodu nie może być więjszy niż obecny.");
            }
        }
        get
        {
            return _rocznik;
        }
    }
    public int Przebieg
    {
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Przebieg samochodu nie może być mniejszy bądź równy 0.");
            }

        }
        get
        {
            return _przebieg;
        }
    }
    public double Silnik { get; set; }

    public bool Klima { get; set; }
    public bool Szyby { get; set; }
    public bool Radio { get; set; }
    public bool Zamek { get; set; }
    public int Cena { get; set; }

}
public class Marka : Auto
{
    public Marka()
    {
    }
    public Marka(string M)
    {
        Markaa = M;
    }


    public void JakaMarka()
    {
        Console.WriteLine("Wybierz markę samochodu wpisując przypisaną jej liczbę.");

    }
}

class Lakier : Auto
{
    public void Paint()
    {
        Console.WriteLine("Jaki kolor lakieru?");
        
    }
}

class Rocznik : Auto
{
    public void Year()
    {
        Console.WriteLine("Jaki jest rocznik samochodu? (yyyy)");
    }
}

class Program : Auto
{
    public static void Main()
    {
        Marka m = new Marka();
        m.JakaMarka();

        string[] Names = Enum.GetNames(typeof(Marki));
        int[] Values = (int[])Enum.GetValues(typeof(Marki));

        for (int v = 0; v < Names.Length; v++)
        {
            Console.WriteLine("{0} - {1}", Values[v], Names[v]);
        }
        string ChosenBrand = Console.ReadLine();

        Lakier p = new Lakier();
        p.Paint();
        string Paintcolour = Console.ReadLine();

        Rocznik y = new Rocznik();
        y.Year();
        string YearofProduction = Console.ReadLine();
        int i = 0;
        bool ifyearis = int.TryParse(YearofProduction, out i);
        if (ifyearis)
        {
            Console.WriteLine(i);
                }
        else
        {
            Console.WriteLine("Wpisz poprawny rocznik. (yyyy)");
        }
   
    }
}


