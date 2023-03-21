
using ApresLiskov;

public class Program
{

    public static void Main(string[] args)
    {
        Animal animal1 = new Gato();

        ((Gato)animal1).Comer();
    }
}