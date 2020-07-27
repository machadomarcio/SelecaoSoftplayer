using Microsoft.AspNetCore.Mvc;

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
