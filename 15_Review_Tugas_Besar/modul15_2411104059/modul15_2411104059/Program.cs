using System;

class Program
{
    static void Main()
    {
        var userService = new UserService();
        var users = userService.LoadUsers();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== MENU ====");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Register(users, userService);
                    break;
                case "2":
                    Login(users, userService);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu...");
            Console.ReadLine();
        }
    }

    static void Register(List<User> users, UserService service)
    {
        Console.Clear();
        Console.WriteLine("== REGISTRASI ==");

        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        if (users.Any(u => u.Username == username))
        {
            Console.WriteLine("Username sudah terdaftar.");
            return;
        }

        Console.Write("Masukkan password: ");
        string password = ReadPassword();

        if (!service.ValidatePassword(password, username, out string error))
        {
            Console.WriteLine($"Gagal: {error}");
            return;
        }

        string hash = service.HashPassword(password);
        users.Add(new User { Username = username, PasswordHash = hash });
        service.SaveUsers(users);

        Console.WriteLine("Registrasi berhasil!");
    }

    static void Login(List<User> users, UserService service)
    {
        Console.Clear();
        Console.WriteLine("== LOGIN ==");

        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan password: ");
        string password = ReadPassword();
        string hash = service.HashPassword(password);

        var user = users.FirstOrDefault(u => u.Username == username && u.PasswordHash == hash);
        if (user != null)
        {
            Console.WriteLine("Login berhasil! Selamat datang " + user.Username);
        }
        else
        {
            Console.WriteLine("Login gagal. Username atau password salah.");
        }
    }

    static string ReadPassword()
    {
        string password = "";
        ConsoleKey key;
        do
        {
            var keyInfo = Console.ReadKey(true);
            key = keyInfo.Key;

            if (key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                password += keyInfo.KeyChar;
                Console.Write("*");
            }

        } while (key != ConsoleKey.Enter);
        Console.WriteLine();
        return password;
    }
}
