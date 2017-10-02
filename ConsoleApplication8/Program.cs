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
class Marka : Auto
{
    public Marka()
    {
    }
    public Marka(string M)
    {
        Markaa = M;
    }

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



    //public void Marki()
    //{
    //    Marka[] marki = new Marka[18];
    //    marki[0] = new Marka("Audi");
    //    marki[1] = new Marka("Citroen");
    //    marki[2] = new Marka("Dacia");
    //    marki[3] = new Marka("Daewoo");
    //    marki[4] = new Marka("Dodge");
    //    marki[5] = new Marka("Fiat");
    //    marki[6] = new Marka("Ford");
    //    marki[7] = new Marka("Honda");
    //    marki[8] = new Marka("Hyundai");
    //    marki[9] = new Marka("Jeep");
    //    marki[10] = new Marka("Kia");
    //    marki[11] = new Marka("Mazda");
    //    marki[12] = new Marka("Mercedes-Benz");
    //    marki[13] = new Marka("Mitsubishi");
    //    marki[14] = new Marka("Nissan");
    //    marki[15] = new Marka("Opel");
    //    marki[16] = new Marka("Peugeot");
    //    marki[17] = new Marka("Renault");

    //    foreach (Marka m in marki)
    //    {
    //        Console.WriteLine("{0}", m.Markaa);
    //    }
    //}
  
    
    public void JakaMarka()
    {
        Console.WriteLine("Wybierz markę samochodu wpisując przypisaną jej liczbę.");

    }
}

class Lakier
{

}
class Program : Marka
{
    public static void Main()
    {
        Marka m = new Marka();
        m.JakaMarka();
        string[] Names = Enum.GetNames(typeof(Marki));
        int[] Values = (int[])Enum.GetValues(typeof(Marki));
        foreach (string n in Names) ;
        foreach (int v in Values)
        {
            Console.WriteLine("{0} - {1}", v, n);
        }
        //m.Marki();
        string ChosenBrand = Console.ReadLine();
        Console.ReadKey();

        
    }
}


