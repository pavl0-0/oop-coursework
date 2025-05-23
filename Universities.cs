using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace CourseWork
{
    public class Universities
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Specialties { get; set; }
        public string LearnForm { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public decimal MinMark { get; set; }
        public decimal MaxMark { get; set; }
        public decimal Money { get; set; }

        public string UniversityNameFull { get; set; }
        public string AddressFull { get; set; }
        public string SpecialtiesFull { get; set; } 
        public string MarksFull { get; set; }
        public string LearnFormFull { get; set; }
        public string MoneyFull { get; set; }
        public string DescriptionFull { get; set; }
        public string PhotoPath { get; set; }

        public bool IsSameUniversity(Universities other)
        {
            return Name == other.Name && Address == other.Address;
        }

        public Universities()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

    class UniversitiesManager
    {
        private const string FilePath = "universities_database.json";
        private List<Universities> universities;

        public UniversitiesManager()
        {
            LoadUniversities();
        }

        private void LoadUniversities()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(FilePath);
                    universities = JsonSerializer.Deserialize<List<Universities>>(jsonString);
                    if (universities == null)
                    {
                        universities = new List<Universities>();
                        Console.WriteLine($"Попередження: '{FilePath}' був порожнім або містив недійсний JSON. Ініціалізуємо порожній список.");
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Помилка десеріалізації JSON з '{FilePath}': {ex.Message}");
                    universities = new List<Universities>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка читання з '{FilePath}': {ex.Message}");
                    universities = new List<Universities>();
                }
            }
            else
            {
                universities = new List<Universities>();
                Console.WriteLine($"Попередження: '{FilePath}' не знайдено. Ініціалізуємо порожній список університетів.");
            }
        }

        public List<Universities> GetAllUniversities()
        {
            return new List<Universities>(this.universities);
        }

        public void AddUniversity(Universities newUniversity)
        {
            if (universities == null)
            {
                universities = new List<Universities>();
            }
            if (universities.Any(u => u.IsSameUniversity(newUniversity)))
            {
                Console.WriteLine($"Університет з назвою '{newUniversity.Name}' та адресою '{newUniversity.Address}' вже існує.");
                return;
            }
            universities.Add(newUniversity);
            SaveUniversities();
        }

        public void UpdateUniversity(Universities updatedUniversity)
        {
            if (universities == null) return;

            var existingUniversity = universities.FirstOrDefault(u => u.Id == updatedUniversity.Id);

            if (existingUniversity != null)
            {
                existingUniversity.Name = updatedUniversity.Name; 
                existingUniversity.Address = updatedUniversity.Address; 
                existingUniversity.Specialties = updatedUniversity.Specialties;
                existingUniversity.LearnForm = updatedUniversity.LearnForm;
                existingUniversity.City = updatedUniversity.City;
                existingUniversity.MinMark = updatedUniversity.MinMark;
                existingUniversity.MaxMark = updatedUniversity.MaxMark;
                existingUniversity.Money = updatedUniversity.Money;

                existingUniversity.UniversityNameFull = updatedUniversity.UniversityNameFull;
                existingUniversity.AddressFull = updatedUniversity.AddressFull;
                existingUniversity.SpecialtiesFull = updatedUniversity.SpecialtiesFull;
                existingUniversity.MarksFull = updatedUniversity.MarksFull;
                existingUniversity.LearnFormFull = updatedUniversity.LearnFormFull;
                existingUniversity.MoneyFull = updatedUniversity.MoneyFull;
                existingUniversity.DescriptionFull = updatedUniversity.DescriptionFull;
                existingUniversity.PhotoPath = updatedUniversity.PhotoPath;

                SaveUniversities();
                Console.WriteLine($"Університет '{updatedUniversity.Name}' оновлено.");
            }
            else
            {
                Console.WriteLine($"Університет з ID '{updatedUniversity.Id}' не знайдено для оновлення."); // Змінено повідомлення
            }
        }

        public void DeleteUniversity(string name, string address)
        {
            if (universities == null) return;

            var universityToRemove = universities.FirstOrDefault(u => u.Name == name && u.Address == address);
            if (universityToRemove != null)
            {
                universities.Remove(universityToRemove);
                SaveUniversities();
                Console.WriteLine($"Університет '{name}' видалено.");
            }
            else
            {
                Console.WriteLine($"Університет '{name}' не знайдено для видалення.");
            }
        }

        public void SaveUniversities()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(universities, options);
                File.WriteAllText(FilePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка збереження університетів у '{FilePath}': {ex.Message}");
            }
        }

        public List<string> GetUniqueCities()
        {
            if (universities == null)
            {
                return new List<string>();
            }
            return universities.Select(u => u.City).Distinct().OrderBy(c => c).ToList();
        }

        public List<Universities> SearchUniversities(
            string searchName, string searchAddress, string searchSpecialty,
            string searchMinMark, string searchMaxMark, string searchMinMoney,
            string searchMaxMoney, string searchForm, string searchCity)
        {
            if (universities == null)
            {
                return new List<Universities>();
            }

            var query = universities.AsEnumerable();

            if (!string.IsNullOrEmpty(searchName))
                query = query.Where(u => u.Name.ToLower().Contains(searchName.ToLower()));
            if (!string.IsNullOrEmpty(searchAddress))
                query = query.Where(u => u.Address.ToLower().Contains(searchAddress.ToLower()));

            if (!string.IsNullOrEmpty(searchSpecialty))
            {
                if (int.TryParse(searchSpecialty, out int specialtyId))
                {
                    query = query.Where(u => u.Specialties == specialtyId);
                }
                else
                {
                    Console.WriteLine($"Попередження: 'Спеціальність' '{searchSpecialty}' не є дійсним числом і буде проігнорована.");
                }
            }

            if (!string.IsNullOrEmpty(searchForm))
                query = query.Where(u => u.LearnForm.ToLower().Contains(searchForm.ToLower()));
            if (!string.IsNullOrEmpty(searchCity))
                query = query.Where(u => u.City.ToLower().Contains(searchCity.ToLower()));

            decimal minMarkSearch = 0, maxMarkSearch = decimal.MaxValue;
            bool hasMinMarkSearch = decimal.TryParse(searchMinMark, out minMarkSearch);
            bool hasMaxMarkSearch = decimal.TryParse(searchMaxMark, out maxMarkSearch);

            if (hasMinMarkSearch || hasMaxMarkSearch)
            {
                query = query.Where(u =>
                {
                    return (!hasMinMarkSearch || u.MinMark >= minMarkSearch) && (!hasMaxMarkSearch || u.MaxMark <= maxMarkSearch);
                });
            }

            decimal minMoneySearch = 0, maxMoneySearch = decimal.MaxValue;
            bool hasMinMoneySearch = decimal.TryParse(searchMinMoney, out minMoneySearch);
            bool hasMaxMoneySearch = decimal.TryParse(searchMaxMoney, out maxMoneySearch);

            if (hasMinMoneySearch || hasMaxMoneySearch)
            {
                query = query.Where(u =>
                {
                    return (!hasMinMoneySearch || u.Money >= minMoneySearch) && (!hasMaxMoneySearch || u.Money <= maxMoneySearch);
                });
            }

            return query.ToList();
        }
    }
}