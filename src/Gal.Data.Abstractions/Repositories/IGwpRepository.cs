using System.Threading.Tasks;

namespace Gal.Data.Abstractions.Repositories
{
    public interface IGwpRepository
    {
        /// <summary>
        /// Returns average gwp for period (inclusive)
        /// </summary>
        /// <param name="country"></param>
        /// <param name="beginYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        Task<double> GetAverageForPeriodAsync(string country, string lob, int beginYear, int endYear);
    }
}