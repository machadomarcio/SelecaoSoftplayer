using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TaxaJuros.Controllers
{
    [ApiController]
    [Route("")]
    public class TaxaJurosController : ControllerBase
    {
        static readonly decimal TaxaJuro = 0.01M;

        [HttpGet]
        [Route("taxaJuros")]
        public decimal GetTaxaJuro()
        {
            return TaxaJuro;
        }
    }
}
