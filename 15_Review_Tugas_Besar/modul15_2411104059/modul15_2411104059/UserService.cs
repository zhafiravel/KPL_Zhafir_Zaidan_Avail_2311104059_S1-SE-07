using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

public class UserService
{
    private const string FilePath = "users.json";

    // Simpan user ke file JSON
    public void SaveUsers(List<User> users)
    {
        var json = JsonSerializer.Serialize(users);
        File.WriteAllText(FilePath, json);
    }

    // Load user dari file
    public List<User> LoadUsers()
    {
        if (!File.Exists(FilePath))
            return new List<User>();

        var json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<User>>(json);
    }

    // Hash password dengan SHA256
    public string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hashBytes = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hashBytes);
    }

    // Validasi password rules
    public bool ValidatePassword(string password, string username, out string error)
    {
        error = "";

        if (password.Length < 8 || password.Length > 20)
        {
            error = "Password harus 8-20 karakter.";
            return false;
        }

        if (!password.Any(char.IsUpper))
        {
            error = "Password harus mengandung huruf kapital.";
            return false;
        }

        if (!password.Any(char.IsDigit))
        {
            error = "Password harus mengandung angka.";
            return false;
        }

        if (!password.Any(c => "!@#$%^&*".Contains(c)))
        {
            error = "Password harus mengandung simbol spesial (!@#$%^&*).";
            return false;
        }

        if (password.ToLower().Contains(username.ToLower()))
        {
            error = "Password tidak boleh mengandung username.";
            return false;
        }

        return true;
    }
}
