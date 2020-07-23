using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TaxaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {

        static readonly decimal TaxaJuro = 0.01M;

        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogDebug("iniciando endpoint que retorna a taxa de juro");
            return Ok(TaxaJuro);
        }
    }
}
