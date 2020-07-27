using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NetCore.TaxaJuros.Service.Interfaces;
using NetCore.TaxaJuros.Service.Services;
using System.IO;
using System.Threading.Tasks;

namespace NetCore.CalculaJuros.Controllers
{
    [ApiController]
    [Route("")]
    public class CalculaJurosController : ControllerBase
    {

        public static IConfigurationRoot Configuration { get; set; }

        [HttpGet]
        [Route("calculajuros")]
        public async System.Threading.Tasks.Task<string> GetCalculoJurosAsync(decimal valorInicial, int meses)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var urlApiTaxaJuro = Configuration["TaxaJuros:Url"];

            ITaxaJurosService taxaJurosService = new TaxaJurosService();
            decimal taxaJuro = await taxaJurosService.GetTaxaDeJuro(urlApiTaxaJuro);

            var calculoJuro = new JuroComposto(valorInicial, meses, taxaJuro);
            return calculoJuro.ValorFinal;
        }
    }
}
