using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseWork
{
    public class UniversityDetails
    {
        public string Id { get; set; }
        public string UniversityNameFull { get; set; }
        public string AddressFull { get; set; }
        public string SpecialtiesFull { get; set; }
        public string MarksFull { get; set; }
        public string LearnFormFull { get; set; }
        public string MoneyFull { get; set; }
        public string DescriptionFull { get; set; }
        public string PhotoPath { get; set; }
    }

    public class UniversityDetailsManager
    {
        private const string FilePath = "universities_details.json";
        private List<UniversityDetails> details = new();

        public UniversityDetailsManager() => Load();

        public void Load()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                details = JsonSerializer.Deserialize<List<UniversityDetails>>(json) ?? new List<UniversityDetails>();
            }
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(details, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public List<UniversityDetails> GetAll() => new(details);

        public void Add(UniversityDetails detail)
        {
            if (details.Any(x => x.Id == detail.Id)) return;
            details.Add(detail);
            Save();
        }

        public void Update(UniversityDetails updated)
        {
            var existing = details.FirstOrDefault(d => d.Id == updated.Id);
            if (existing != null)
            {
                existing.UniversityNameFull = updated.UniversityNameFull;
                existing.AddressFull = updated.AddressFull;
                existing.SpecialtiesFull = updated.SpecialtiesFull;
                existing.MarksFull = updated.MarksFull;
                existing.LearnFormFull = updated.LearnFormFull;
                existing.MoneyFull = updated.MoneyFull;
                existing.DescriptionFull = updated.DescriptionFull;
                existing.PhotoPath = updated.PhotoPath;
                Save();
            }
        }

        public void Delete(string id)
        {
            var d = details.FirstOrDefault(x => x.Id == id);
            if (d != null)
            {
                details.Remove(d);
                Save();
            }
        }
    }
}
