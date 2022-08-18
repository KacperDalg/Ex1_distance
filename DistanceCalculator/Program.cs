using System.IO;

namespace ConsoleApp1

{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dystans w kilometrach: ");
            double distKilometers = Convert.ToDouble(Console.ReadLine());
            double distMeters = distKilometers * 1000;
            Console.WriteLine($"{distKilometers} kilometrów to {distMeters} metrów.");

            var path = "plik.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(distMeters);
            sw.Close();
            Console.WriteLine("---");
            Console.WriteLine("Zapisano do pliku");

        }
    }

}