using FastFoodManagement.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodManagement.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{ver:apiVersion}/product]")]
    public class ProductController : BaseController
    {
        public ProductController()
        {

        }
    }
}
