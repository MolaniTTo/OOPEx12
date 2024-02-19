using OOPEx12;

public class Program
{
    public static void Main()
    {
        Furniture furniture = new Furniture(125 ,250.99, true, "Arnau", "Acero", "Gris" );

        Console.WriteLine(furniture.ToString());

    }
}
