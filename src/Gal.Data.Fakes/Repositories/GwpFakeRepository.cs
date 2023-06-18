using Gal.Data.Abstractions.Repositories;
using Gal.Data.Fakes.Database;
using System.Linq;
using System.Threading.Tasks;

namespace Gal.Data.Fakes.Repositories
{
    internal class GwpFakeRepository : IGwpRepository
    {
        private readonly FakeDatabase _database;

        public GwpFakeRepository(FakeDatabase database)
        {
            _database = database;
        }

        public Task<double> GetAverageForPeriodAsync(string country, string lob, int beginYear, int endYear)
        {
            var avg = _database.Gwps
                            .Where(p => p.Country == country)
                            .Where(p => p.Lob == lob)
                            .Where(p => p.Year >= beginYear && p.Year <= endYear)
                            .Select(s => s.GwpValue)
                            .DefaultIfEmpty(0)
                            .Average();
            return Task.FromResult(avg);
        }
    }
}
