using System;
public class Auto
{
   
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

    public int Rocznik { set; get; }
    
    public int Przebieg { set; get; }
   
            //if (value <= 0)
            //{
            //    Console.WriteLine("Przebieg samochodu nie może być mniejszy bądź równy 0.");
            //}

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
                flag = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny numer.");
            }
            
        }
        while (flag);

        //else 
        //{
        //    Console.WriteLine("Wpisz poprawny numer.");
        //}

        //switch (int.Parse(ChosenBrand))
        //{
        //    case Values:
        //        break;
        //    default:
        //        Console.WriteLine("Wpisz poprawny numer.");
        //        break;
        //}

        //if ( int.Parse(ChosenBrand) != )
        //{
        //    Console.WriteLine("Wpisz poprawny numer.");
        //}



        Auto p = new Auto();
        p.Paint();
        string Paintcolour = Console.ReadLine();


        Auto y = new Auto();
        y.AskForYearOfCarProducion();
       
        do
        {
            
            string YearofProduction = Console.ReadLine();
            int i = 0;

            if (int.TryParse(YearofProduction, out i) && i > 1950 && i <= DateTime.Now.Year)
            {
                y.Rocznik = i;
                flag = false;
            }
            else
            {
                Console.WriteLine("Wpisz poprawny rocznik. (yyyy)");
            }
        }
        while (flag);
       
        }
}


