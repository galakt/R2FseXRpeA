using Gal.Data.Abstractions.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gal.Gwp
{
    internal class GwpModule : IGwpModule
    {
        private readonly IGwpRepository _gwpRepository;

        public GwpModule(IGwpRepository gwpRepository)
        {
            _gwpRepository = gwpRepository;
        }

        public async Task<IDictionary<string, double>> GetAvgAsync(string country, List<string> lobs)
        {
            var res = new Dictionary<string, double>();
            foreach (var lob in lobs)
            {
                var avg = await _gwpRepository.GetAverageForPeriodAsync(country, lob, 2008, 2015);
                res[lob] = avg;
            }
            return res;
        }
    }
}
