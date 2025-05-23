using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseWork
{
    class UniversitiesDetails : UniversitiesDescription
    {

    }

    class UniversitiesDetailsMananger
    {
        private const string FilePath = "universities_database_details.json";
        public List<UniversitiesDetails> LoadUniversities()
        {
            if (!File.Exists(FilePath))
            {
                return new List<UniversitiesDetails>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<UniversitiesDetails>>(json) ?? new List<UniversitiesDetails>();
        }

        public void SaveUniversities(List<UniversitiesDetails> universities)
        {
            string json = JsonSerializer.Serialize(universities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}
