using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace NetCore.CalculaJuros.IntegrationTest
{
    public class TaxaJurosIntegrationTest
    {
        [Fact]
        public async Task CalculaJurosIntegrationTest_CalculaJuros_ReturnOK()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/taxaJuros");

                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
