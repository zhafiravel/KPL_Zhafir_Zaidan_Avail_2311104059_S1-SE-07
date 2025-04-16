using System;

class Program
{
    static void Main()
    {
        var config = BankTransferConfig.Load("bank_transfer_config.json");

        Console.WriteLine(config.lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:");

        int amount = int.Parse(Console.ReadLine());
        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (config.lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }

        Console.WriteLine(config.lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        int methodInput = int.Parse(Console.ReadLine());

        Console.WriteLine(config.lang == "en"
            ? $"Please type \"{config.confirmation.en}\" to confirm the transaction:"
            : $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:");

        string confirmation = Console.ReadLine();
        bool confirmed = config.lang == "en"
            ? confirmation == config.confirmation.en
            : confirmation == config.confirmation.id;

        Console.WriteLine(config.lang == "en"
            ? (confirmed ? "The transfer is completed" : "Transfer is cancelled")
            : (confirmed ? "Proses transfer berhasil" : "Transfer dibatalkan"));
    }
}
