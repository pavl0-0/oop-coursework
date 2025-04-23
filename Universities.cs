using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseWork
{
    class Universities
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Specialties { get; set; }
        public string LearnForm { get; set; }

        public double MinDayMark { get; set; }
        public double MinCorrespondenceMark { get; set; }
        public double MinEveningMark { get; set; }

        public double MaxDayMark { get; set; }
        public double MaxCorrespondenceMark { get; set; }
        public double MaxEveningMark { get; set; }
    }

    class UniversitiesMananger
    {
        private const string FilePath = "universities_database.json";
        public List<Universities> LoadUniversities()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Universities>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Universities>>(json) ?? new List<Universities>();
        }

        public void SaveUniversities(List<Universities> universities)
        {
            string json = JsonSerializer.Serialize(universities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}
