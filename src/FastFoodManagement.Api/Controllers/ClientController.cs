using FastFoodManagement.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodManagement.Api.Controllers
{
    [ApiController]
    //TODO - [TokenAuthorize()]
    [ApiVersion("1.0")]
    [Route("v{ver:apiVersion}/client")]
    public class ClientController : BaseController
    {
        public ClientController()
        {

        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetClient([FromRoute] int id)
        => id % 2 == 0 ? await Task.FromResult(Ok(id)) : await Task.FromResult(NoContent());
    }
}
