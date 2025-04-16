using System;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = CovidConfig.LoadFromFile("covid_config.json");

        // Ubah satuan dulu (G)
        config.UbahSatuan();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        // Cek kondisi suhu
        bool suhuNormal = false;
        if (config.satuan_suhu.ToLower() == "celcius")
        {
            if (suhu >= 36.5 && suhu <= 37.5)
                suhuNormal = true;
        }
        else if (config.satuan_suhu.ToLower() == "fahrenheit")
        {
            if (suhu >= 97.7 && suhu <= 99.5)
                suhuNormal = true;
        }

        // Cek hari demam
        int batasHari = int.Parse(config.batas_hari_deman);
        bool demamOk = hariDemam < batasHari;

        if (suhuNormal && demamOk)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}
