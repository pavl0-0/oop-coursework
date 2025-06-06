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
        public UniversityBasic Basic { get; set; }
        public UniversityStats Stats { get; set; }
        public UniversityDetails Details { get; set; }

        public Universities()
        {
            Id = Guid.NewGuid().ToString();
            Basic = new UniversityBasic();
            Stats = new UniversityStats();
            Details = new UniversityDetails();
        }

        public bool IsSameUniversity(Universities other)
        {
            return Basic.Name == other.Basic.Name && Basic.Address == other.Basic.Address;
        }
    }
    public class UniversitiesManager
    {
        private UniversityBasicManager _basicManager;
        private UniversityStatsManager _statsManager;
        private UniversityDetailsManager _detailsManager;

        public const string FilePath = "universities_combined.json";

        public UniversitiesManager()
        {
            _basicManager = new UniversityBasicManager();
            _statsManager = new UniversityStatsManager();
            _detailsManager = new UniversityDetailsManager();
        }

        public void AddUniversity(Universities university)
        {
            if (string.IsNullOrEmpty(university.Basic.Id))
                university.Basic.Id = Guid.NewGuid().ToString();
            if (string.IsNullOrEmpty(university.Stats.Id))
                university.Stats.Id = university.Basic.Id;
            if (string.IsNullOrEmpty(university.Details.Id))
                university.Details.Id = university.Basic.Id;

            university.Id = university.Basic.Id;

            _basicManager.Add(university.Basic);
            _statsManager.Add(university.Stats);
            _detailsManager.Add(university.Details);
        }

        public void UpdateUniversity(Universities updatedUniversity)
        {
            if (updatedUniversity == null || string.IsNullOrEmpty(updatedUniversity.Id))
            {
                throw new ArgumentNullException(nameof(updatedUniversity), "University to update cannot be null and must have an Id.");
            }

            updatedUniversity.Basic.Id = updatedUniversity.Id;
            updatedUniversity.Stats.Id = updatedUniversity.Id;
            updatedUniversity.Details.Id = updatedUniversity.Id;

            _basicManager.Update(updatedUniversity.Basic);
            _statsManager.Update(updatedUniversity.Stats);
            _detailsManager.Update(updatedUniversity.Details);
        }

        public void DeleteUniversity(string universityId)
        {
            _basicManager.Delete(universityId);
            _statsManager.Delete(universityId);
            _detailsManager.Delete(universityId);
        }

        public List<Universities> SearchUniversities(
            string name, string address, string specialty, string minMark, string maxMark,
            string minMoney, string maxMoney, string form, string city)
        {
            var allBasic = _basicManager.GetAll();
            var allStats = _statsManager.GetAll();
            var allDetails = _detailsManager.GetAll();

            decimal? parsedMinMark = decimal.TryParse(minMark, out decimal mMark) ? mMark : (decimal?)null;
            decimal? parsedMaxMark = decimal.TryParse(maxMark, out decimal MMark) ? MMark : (decimal?)null;
            decimal? parsedMinMoney = decimal.TryParse(minMoney, out decimal mMoney) ? mMoney : (decimal?)null;
            decimal? parsedMaxMoney = decimal.TryParse(maxMoney, out decimal MMoney) ? MMoney : (decimal?)null;
            int? parsedSpecialty = int.TryParse(specialty, out int spec) ? spec : (int?)null;


            var filteredBasic = allBasic.Where(b =>
                (string.IsNullOrEmpty(name) || b.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(address) || b.Address.Contains(address, StringComparison.OrdinalIgnoreCase)) &&
                (!parsedSpecialty.HasValue || b.Specialties == parsedSpecialty.Value) &&
                (string.IsNullOrEmpty(form) || b.LearnForm.Equals(form, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(city) || b.City.Equals(city, StringComparison.OrdinalIgnoreCase))
            );

            var filteredStats = allStats.Where(s =>
                (!parsedMinMark.HasValue || s.MinMark >= parsedMinMark.Value) &&
                (!parsedMaxMark.HasValue || s.MaxMark <= parsedMaxMark.Value) &&
                (!parsedMinMoney.HasValue || s.Money >= parsedMinMoney.Value) &&
                (!parsedMaxMoney.HasValue || s.Money <= parsedMaxMoney.Value)
            );

            var query = from basic in filteredBasic
                        join stats in filteredStats on basic.Id equals stats.Id
                        join details in allDetails on basic.Id equals details.Id into detailsGroup
                        from details in detailsGroup.DefaultIfEmpty()
                        select new Universities
                        {
                            Id = basic.Id,
                            Basic = basic,
                            Stats = stats,
                            Details = details ?? new UniversityDetails()
                        };

            return query.ToList();
        }

        public List<string> GetUniqueCities()
        {
            return _basicManager.GetUniqueCities();
        }

        public List<string> GetAllSpecialties()
        {
            return _basicManager.GetAllSpecialties();
        }

        public List<string> GetAllAddresses()
        {
            return _basicManager.GetAllAddresses();
        }

        public List<string> GetAllNames()
        {
            return _basicManager.GetAllNames();
        }

        public Universities GetUniversityById(string id)
        {
            var basic = _basicManager.GetAll().FirstOrDefault(b => b.Id == id);
            if (basic == null) return null;

            var stats = _statsManager.GetAll().FirstOrDefault(s => s.Id == id);
            var details = _detailsManager.GetAll().FirstOrDefault(d => d.Id == id);

            return new Universities
            {
                Id = id,
                Basic = basic,
                Stats = stats ?? new UniversityStats { Id = id },
                Details = details ?? new UniversityDetails { Id = id }
            };
        }

        public List<Universities> GetAllUniversities()
        {
            var allBasic = _basicManager.GetAll();
            var allStats = _statsManager.GetAll();
            var allDetails = _detailsManager.GetAll();

            var query = from basic in allBasic
                        join stats in allStats on basic.Id equals stats.Id
                        join details in allDetails on basic.Id equals details.Id into detailsGroup
                        from details in detailsGroup.DefaultIfEmpty()
                        select new Universities
                        {
                            Id = basic.Id,
                            Basic = basic,
                            Stats = stats,
                            Details = details ?? new UniversityDetails()
                        };
            return query.ToList();
        }
    }
}