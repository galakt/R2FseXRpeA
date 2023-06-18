using Gal.Gwp;
using Gal.Models.Gwp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gal.Controllers
{
    [Route("server/api/gwp")]
    [ApiController]
    public class GwpController : ControllerBase
    {
        private readonly ILogger<GwpController> _logger;
        private readonly IGwpModule _gwpModule;

        public GwpController(ILogger<GwpController> logger,
                             IGwpModule gwpModule)
        {
            _logger = logger;
            _gwpModule = gwpModule;
        }

        [HttpPost("avg")]
        public async Task<IDictionary<string, double>> Avg([FromBody] GwpAvgRequest request)
        {
            var res = await _gwpModule.GetAvgAsync(request.Country, request.Lob);
            return res;
        }
    }
}
