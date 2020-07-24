using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace NetCore.CalculaJuros.IntegrationTest
{
    public class ShowMeTheCodeIntegrationTest
    {
        [Fact]
        public async Task ShowMeTheCodeIntegrationTest_CShowMeTheCode_ReturnOK()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/showmethecode");

                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
