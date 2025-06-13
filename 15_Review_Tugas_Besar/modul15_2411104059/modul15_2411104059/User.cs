using System.Text.Json.Serialization;

public class User
{
    public string Username { get; set; }

    // Disimpan dalam bentuk hash
    public string PasswordHash { get; set; }

    [JsonIgnore]
    public string RawPassword { get; set; } // opsional untuk proses input (tidak disimpan)
}
