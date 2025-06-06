using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CourseWork
{
    public class UniversityStats
    {
        public string Id { get; set; }
        public decimal MinMark { get; set; }
        public decimal MaxMark { get; set; }
        public decimal Money { get; set; }
    }

    public class UniversityStatsManager
    {
        private const string FilePath = "universities_stats.json";
        private List<UniversityStats> stats = new();

        public UniversityStatsManager() => Load();

        public void Load()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                stats = JsonSerializer.Deserialize<List<UniversityStats>>(json) ?? new List<UniversityStats>();
            }
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(stats, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public List<UniversityStats> GetAll() => new(stats);

        public void Add(UniversityStats s)
        {
            if (stats.Any(x => x.Id == s.Id)) return;
            stats.Add(s);
            Save();
        }

        public void Update(UniversityStats updated)
        {
            var existing = stats.FirstOrDefault(s => s.Id == updated.Id);
            if (existing != null)
            {
                existing.MinMark = updated.MinMark;
                existing.MaxMark = updated.MaxMark;
                existing.Money = updated.Money;
                Save();
            }
        }

        public void Delete(string id)
        {
            var item = stats.FirstOrDefault(s => s.Id == id);
            if (item != null)
            {
                stats.Remove(item);
                Save();
            }
        }

        public List<UniversityStats> Filter(decimal? minMark, decimal? maxMark, decimal? minMoney, decimal? maxMoney)
        {
            return stats.Where(s =>
                (!minMark.HasValue || s.MinMark >= minMark) &&
                (!maxMark.HasValue || s.MaxMark <= maxMark) &&
                (!minMoney.HasValue || s.Money >= minMoney) &&
                (!maxMoney.HasValue || s.Money <= maxMoney)
            ).ToList();
        }
    }
}