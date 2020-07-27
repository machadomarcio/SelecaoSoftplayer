using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.TaxaJuros.Service.Interfaces
{
    public interface ITaxaJurosService
    {
        Task<decimal> GetTaxaDeJuro(string urlApiTaxaJuro);
    }
}
