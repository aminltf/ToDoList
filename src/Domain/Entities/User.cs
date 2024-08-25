#nullable disable

using Domain.Common;

namespace Domain.Entities;

public class User(string username, string passwordHash, string passwordSalt, string role) : BaseEntity<int>()
{
    public string Username { get; set; } = username;
    public string PasswordHash { get; set; } = passwordHash;
    public string PasswordSalt { get; set; } = passwordSalt;
    public string Role { get; set; } = role;
}
