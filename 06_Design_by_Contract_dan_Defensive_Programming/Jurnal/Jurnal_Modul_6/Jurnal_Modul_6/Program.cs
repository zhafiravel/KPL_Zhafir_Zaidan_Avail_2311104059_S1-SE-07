using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama Anda: ");
        string username = Console.ReadLine() ?? "UserDefault";

        // Membuat objek SayaTubeUser
        SayaTubeUser user = new SayaTubeUser(username);

        // Input 10 judul film
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Masukkan judul film ke-{i}: ");
            string? judulFilm = Console.ReadLine();
            if (string.IsNullOrEmpty(judulFilm)) judulFilm = "Judul Default";

            SayaTubeVideo video = new SayaTubeVideo(judulFilm);
            user.AddVideo(video);
        }

        // Menampilkan semua video
        user.PrintAllVideoPlaycount();

        // Pilih video untuk ditonton
        Console.Write("\nMasukkan indeks video yang ingin ditonton (1-10): ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > 10)
        {
            Console.WriteLine("Indeks tidak valid, memilih video pertama.");
            index = 1;
        }

        Console.Write("Masukkan jumlah penambahan play count: ");
        if (!int.TryParse(Console.ReadLine(), out int tambahPlay) || tambahPlay < 0)
        {
            Console.WriteLine("Input tidak valid, play count ditetapkan ke 1.");
            tambahPlay = 1;
        }

        try
        {
            user.GetUploadedVideos()[index - 1].IncreasePlayCount(tambahPlay);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Terjadi kesalahan: {e.Message}");
        }

        // Menampilkan ulang daftar video setelah update
        user.PrintAllVideoPlaycount();

        Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
        Console.ReadLine();
    }
}
