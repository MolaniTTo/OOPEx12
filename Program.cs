using OOPEx12;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Furniture furniture = new Furniture(125 ,250.99, true, "Arnau", "Acero", "Gris" );

        Requenita eric = new Requenita(true, 125, 250.99, true, "Arnau", "Acero", "Gris");

        Console.WriteLine(eric.GetInfo());

    }

    public static void PrintInfo(Furniture furniture) //Overloading
    {
        Console.WriteLine(furniture.GetInfo());
    }

    public static void PrintInfo(Requenita requenita) //Overloading
    {
        Console.WriteLine(requenita.GetInfo());
    }
}
