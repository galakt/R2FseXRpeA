using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gal.Gwp
{
    public interface IGwpModule
    {
        Task<IDictionary<string, double>> GetAvgAsync(string country, List<string> lobs);
    }
}
