using System;
using TP_modul5_2311104059;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hasil Penjumlahan: " + Penjumlahan.JumlahTigaAngka(12L, 34L, 56L));

        SimpleDataBase<long> database = new SimpleDataBase<long>();

        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);

        database.PrintAllData();
    }
}
