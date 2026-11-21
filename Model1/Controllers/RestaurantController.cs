using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{

    [ApiController]
    public class RestaurantController : ControllerBase
    {
        [HttpGet("system/api/restaurant/list")]
        public ApiResult List()
        {

        }

    }
}
