using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;

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

            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync(urlApiTaxaJuro);

            var taxaJuro = decimal.Parse(response.Content.ReadAsStringAsync().Result.Replace(".", ","));

            var calculoJuro = new JuroComposto(valorInicial, meses, taxaJuro);
            return calculoJuro.ValorFinal;
        }
    }
}
