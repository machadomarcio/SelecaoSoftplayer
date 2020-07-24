using System;

namespace NetCore.CalculaJuros
{
    public class JuroComposto
    {
        public JuroComposto(decimal valorInicial, int meses, decimal taxaJuro)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            TaxaJuro = taxaJuro;
        }

        /// <summary>
        /// Valor Inicial
        /// </summary>
        public decimal ValorInicial { get; set; }

        /// <summary>
        /// Taxa de Juros
        /// </summary>
        public decimal TaxaJuro { get; set; }

        public string ValorFinal => Trucate(ValorInicial * Convert.ToDecimal(Math.Pow((double)(1 + TaxaJuro), Meses))).ToString("F");

        /// <summary>
        /// Quantidade de Meses
        /// </summary>
        public int Meses { get; set; }

        private decimal Trucate(decimal value)
        {
            return Math.Truncate(100 * value) / 100;
        }
    }
}
