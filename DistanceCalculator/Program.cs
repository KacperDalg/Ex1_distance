namespace DistanceCalculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj dystans w kilometrach: ");
        double distanceInKilometers = Convert.ToDouble(Console.ReadLine());
        double distanceInMeters = distanceInKilometers * 1000;
        Console.WriteLine($"{distanceInKilometers} kilometrów to {distanceInMeters} metrów.");
        var path = "plik.txt";
        StreamWriter streamWriter = new StreamWriter(path, true);
        streamWriter.WriteLine(distanceInMeters);
        streamWriter.Close();
        Console.WriteLine("---");
        Console.WriteLine("Zapisano do pliku");
    }
}