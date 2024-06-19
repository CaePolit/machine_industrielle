using machine_industrielle;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the volume of available centiliters (entier):");
        string entry1 = Console.ReadLine();
        int avalaibleBeerVolume = Convert.ToInt32(entry1);
        Console.WriteLine("enter the number of available bottles (entier):");
        string entry2 = Console.ReadLine();
        int avalaibleBottles = Convert.ToInt32(entry2);
        Console.WriteLine("enter the number of available caps (entier):");
        string entry3 = Console.ReadLine();
        int avalaibleCapsules = Convert.ToInt32(entry3);
        BeerEncapsulator beerEncapsulator = new BeerEncapsulator(avalaibleBeerVolume, avalaibleBottles, avalaibleCapsules);

        Console.WriteLine("how many beers you want to produce?: ");
        string entry4 = Console.ReadLine();
        int beersToDo = Convert.ToInt32(entry3);
        int beers = beerEncapsulator.ProduceEncapsulatedBeerBottles(beersToDo);
        Console.WriteLine(beers);
        beerEncapsulator.DisplayMessage(beers, beersToDo);





    }
}