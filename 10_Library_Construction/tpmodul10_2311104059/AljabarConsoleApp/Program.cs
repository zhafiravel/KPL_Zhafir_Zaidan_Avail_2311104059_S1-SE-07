using System;
using AljabarLibraries;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Akar Persamaan Kuadrat ===");
        double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine($"Akar-akarnya: {string.Join(", ", akar)}");

        Console.WriteLine("\n=== Hasil Kuadrat dari 2x - 3 ===");
        double[] kuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine($"Hasil: {kuadrat[0]}x^2 {kuadrat[1]}x + {kuadrat[2]}");
    }
}
