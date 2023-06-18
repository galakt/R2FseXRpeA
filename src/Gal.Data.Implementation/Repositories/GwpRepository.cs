using Gal.Data.Abstractions.Repositories;
using System.Threading.Tasks;

namespace Gal.Data.Implementation.Repositories
{
    internal class GwpRepository : IGwpRepository
    {
        public Task<double> GetAverageForPeriodAsync(string country, string lob, int beginYear, int endYear)
        {
            throw new System.NotImplementedException();
        }
    }
}
