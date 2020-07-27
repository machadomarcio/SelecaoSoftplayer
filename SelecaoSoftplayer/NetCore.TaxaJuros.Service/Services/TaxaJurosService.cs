using NetCore.TaxaJuros.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.TaxaJuros.Service.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public async Task<decimal> GetTaxaDeJuro(string urlApiTaxaJuro)
        {
            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync(urlApiTaxaJuro);

            var taxaJuro = decimal.Parse(response.Content.ReadAsStringAsync().Result.Replace(".", ","));

            return taxaJuro;
        }
    }
}
