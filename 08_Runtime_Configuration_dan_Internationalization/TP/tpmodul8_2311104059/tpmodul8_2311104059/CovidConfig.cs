using System;
using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public string batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public static CovidConfig LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return Default(); // fallback ke default
        }

        string jsonString = File.ReadAllText(filePath);
        CovidConfig config = JsonSerializer.Deserialize<CovidConfig>(jsonString);

        // fallback manual jika properti null
        if (string.IsNullOrEmpty(config.satuan_suhu)) config.satuan_suhu = "celcius";
        if (string.IsNullOrEmpty(config.batas_hari_deman)) config.batas_hari_deman = "14";
        if (string.IsNullOrEmpty(config.pesan_ditolak)) config.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        if (string.IsNullOrEmpty(config.pesan_diterima)) config.pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        return config;
    }

    public static CovidConfig Default()
    {
        return new CovidConfig
        {
            satuan_suhu = "celcius",
            batas_hari_deman = "14",
            pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
            pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
        };
    }

    public void UbahSatuan()
    {
        if (satuan_suhu.ToLower() == "celcius")
        {
            satuan_suhu = "fahrenheit";
        }
        else
        {
            satuan_suhu = "celcius";
        }
    }
}
