using tpmodul14_2311104059;

class Program
{
    static void Main(string[] args)
    {
        // Membuat instance class KodePos untuk mendapatkan kode pos
        KodePos kp = new KodePos();
        Console.WriteLine("Kode pos Cijaura: " + kp.GetKodePos("Cijaura"));

        // Simulasi pergantian status pintu menggunakan state-based
        Console.WriteLine("\nSimulasi DoorMachine:");
        DoorMachine dm = new DoorMachine();
        dm.Toggle(); // buka
        dm.Toggle(); // kunci lagi
    }
}