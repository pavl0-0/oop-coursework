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
        public string fullName { get; set; }
        public List<string> SavedUniversityIds { get; set; } = new List<string>();
    }

    class UserMananger
    {
        private const string FilePath = "user_database.json";
        private const string AdminLogin = "admin";
        private const string AdminPasswordHash = "ZehL4zUy\u002B3hMSBKWdfnv86aCsnFowOp0Syz1juAjN8U=";
        private List<User> users;
        private UniversitiesManager _universitiesManager;

        public UserMananger(UniversitiesManager universitiesManager)
        {
            this.users = LoadUsers();
            _universitiesManager = universitiesManager;
        }

        public List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
            {
                return new List<User>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void SaveUsers(List<User> usersToSave)
        {
            string json = JsonSerializer.Serialize(usersToSave, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public bool Register(string username, string password, string fullName)
        {
            var hashed = HashPassword(password);

            if (username.Equals(AdminLogin, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (this.users.Exists(u => u.user.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            this.users.Add(new User
            {
                user = username,
                password = hashed,
                role = "user",
                fullName = fullName
            });

            SaveUsers(this.users);
            return true;
        }

        public string Login(string username, string password)
        {
            var hashed = HashPassword(password);

            if (username.Equals(AdminLogin, StringComparison.OrdinalIgnoreCase) && hashed == AdminPasswordHash)
            {
                return "admin";
            }

            var user = this.users.FirstOrDefault(u => u.user == username && u.password == hashed);

            return user?.role;
        }

        public void AddSavedUniversity(string username, string universityId)
        {
            var user = this.users.FirstOrDefault(u => u.user == username);
            if (user != null)
            {
                if (!user.SavedUniversityIds.Contains(universityId))
                {
                    user.SavedUniversityIds.Add(universityId);
                    SaveUsers(this.users);
                }
            }
            else
            {
                throw new Exception("Користувача не знайдено.");
            }
        }

        public List<Universities> GetSavedUniversities(string username)
        {
            var user = this.users.FirstOrDefault(u => u.user == username);
            if (user == null)
            {
                return new List<Universities>();
            }

            var savedIds = user.SavedUniversityIds;

            var allUniversities = _universitiesManager.GetAllUniversities();

            var savedUnis = allUniversities.Where(u => savedIds.Contains(u.Id)).ToList();

            return savedUnis;
        }

        public void RemoveSavedUniversity(string username, string universityId)
        {
            var user = users.FirstOrDefault(u => u.user.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                return;
            }

            if (user.SavedUniversityIds.Contains(universityId))
            {
                user.SavedUniversityIds.Remove(universityId);
                SaveUsers(users);
            }
        }

        public string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hashBytes = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        public Universities GetUniversityById(string id)
        {
            return _universitiesManager.GetUniversityById(id);
        }
    }
}