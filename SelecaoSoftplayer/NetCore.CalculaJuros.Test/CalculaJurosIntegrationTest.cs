using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace NetCore.CalculaJuros.IntegrationTest
{
    public class CalculaJurosIntegrationTest
    {
        [Fact]
        public async Task CalculaJurosIntegrationTest_CalculaJuros_ReturnOK()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/calculajuros?valorInicial=100&meses=5");

                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
