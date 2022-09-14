namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj dystans w kilometrach: ");
        double distanceInKilometers = Convert.ToDouble(Console.ReadLine());
        double distanceInMeters = distanceInKilometers * 1000;
        Console.WriteLine($"{distanceInKilometers} kilometrów to {distanceInMeters} metrów.");
        var path = "plik.txt";
        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(distanceInMeters);
        sw.Close();
        Console.WriteLine("---");
        Console.WriteLine("Zapisano do pliku");
    }
}