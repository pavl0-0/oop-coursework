using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CourseWork
{
    public class UniversityBasic
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Specialties { get; set; }
        public string LearnForm { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }

    public class UniversityBasicManager
    {
        private const string FilePath = "universities_basic.json";
        private List<UniversityBasic> universities = new();

        public UniversityBasicManager() => Load();

        public void Load()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                universities = JsonSerializer.Deserialize<List<UniversityBasic>>(json) ?? new List<UniversityBasic>();
            }
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(universities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public List<UniversityBasic> GetAll() => new(universities);

        public void Add(UniversityBasic uni)
        {
            if (universities.Any(u => u.Name == uni.Name && u.Address == uni.Address)) return;
            universities.Add(uni);
            Save();
        }

        public void Update(UniversityBasic updated)
        {
            var existing = universities.FirstOrDefault(u => u.Id == updated.Id);
            if (existing != null)
            {
                existing.Name = updated.Name;
                existing.City = updated.City;
                existing.Address = updated.Address;
                existing.Specialties = updated.Specialties;
                existing.LearnForm = updated.LearnForm;
                Save();
            }
        }

        public void Delete(string id)
        {
            var toRemove = universities.FirstOrDefault(u => u.Id == id);
            if (toRemove != null)
            {
                universities.Remove(toRemove);
                Save();
            }
        }

        public List<string> GetAllNames()
        {
            return universities.Select(u => u.Name).Where(n => !string.IsNullOrEmpty(n)).Distinct().ToList();
        }

        public List<string> GetAllAddresses()
        {
            return universities.Select(u => u.Address).Where(a => !string.IsNullOrEmpty(a)).Distinct().ToList();
        }

        public List<string> GetAllSpecialties()
        {
            return universities.Select(u => u.Specialties.ToString()).Distinct().ToList();
        }

        public List<string> GetUniqueCities()
        {
            return universities.Select(u => u.City).Where(c => !string.IsNullOrEmpty(c)).Distinct().ToList();
        }
        public List<UniversityBasic> Filter(string city = null, string learnForm = null, int? specialties = null)
        {
            var query = universities.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(city))
            {
                query = query.Where(u => u.City.Equals(city, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(learnForm))
            {
                query = query.Where(u => u.LearnForm.Equals(learnForm, StringComparison.OrdinalIgnoreCase));
            }
            if (specialties.HasValue)
            {
                query = query.Where(u => u.Specialties >= specialties.Value);
            }

            return query.ToList();
        }
    }
}