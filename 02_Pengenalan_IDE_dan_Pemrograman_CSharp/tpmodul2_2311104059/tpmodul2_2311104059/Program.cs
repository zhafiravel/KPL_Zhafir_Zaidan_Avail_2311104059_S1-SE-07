using System;

class Program
{
    static void Main()
    {
        // Bagian A: Menerima input satu karakter
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (huruf == 'A' || huruf == 'I' || huruf == 'U' || huruf == 'E' || huruf == 'O')
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        // Bagian B: Array dengan bilangan genap
        int[] angkaGenap = { 2, 4, 6, 8, 10 };

        for (int i = 0; i < angkaGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {angkaGenap[i]}");
        }
        Console.WriteLine("Tekan Enter untuk keluar...");
        Console.ReadLine();
    }
}
