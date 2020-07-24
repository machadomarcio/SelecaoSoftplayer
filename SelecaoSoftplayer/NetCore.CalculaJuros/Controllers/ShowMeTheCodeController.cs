using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NetCore.CalculaJuros.Controllers
{
    [ApiController]
    [Route("")]
    public class ShowMeTheCodeController : ControllerBase
    {
        private const string UrlGithub = "https://github.com/machadomarcio/SelecaoSoftplayer";

        [HttpGet]
        [Route("showmethecode")]
        public string ShowMeTheCode()
        {
            return UrlGithub;
        }
    }
}
