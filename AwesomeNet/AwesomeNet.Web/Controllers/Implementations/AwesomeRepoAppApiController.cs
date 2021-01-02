using AwesomeNet.Web.Controllers.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeNet.Web.Controllers.Implementations
{
    [Route("api/awesome-repo")]
    public class AwesomeRepoController : BaseAppApiController
    {
        [HttpGet]
        public IActionResult Get() => Ok($"{nameof(AwesomeRepoController)}");
    }
}