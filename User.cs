using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace CourseWork
{
    class User
    {
        public string user { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }

    class UserMananger
    {
        private const string FilePath = "user_database.json";
        private const string AdminLogin = "admin";
        private const string AdminPasswordHash = "ZehL4zUy\u002B3hMSBKWdfnv86aCsnFowOp0Syz1juAjN8U=";

        public List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
                return new List<User>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public bool Register(string username, string password)
        {
            var users = LoadUsers();

            if (users.Exists(u => u.user == username))
                return false;

            var hashed = HashPassword(password);
            string role = (username == AdminLogin && hashed == AdminPasswordHash) ? "admin" : "user";

            users.Add(new User
            {
                user = username,
                password = hashed,
                role = role
            });

            SaveUsers(users);
            return true;
        }

        public string Login(string username, string password)
        {
            var hashed = HashPassword(password);
            const string adminLogin = "admin";
            const string adminPasswordHash = "ZehL4zUy\u002B3hMSBKWdfnv86aCsnFowOp0Syz1juAjN8U=";

            if (username == adminLogin && hashed == adminPasswordHash)
            { 
                return "admin"; 
            }

            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.user == username && u.password == hashed);

            return user?.role;
        }


        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
