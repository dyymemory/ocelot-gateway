using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace order_api.Controllers
{
    //[Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/Order
        [Route("api/orders")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "订单1", "订单11" };
        }
        public IEnumerable<string> GetMore()
        {
            return new string[] { "订单2", "订单22" };
        }
    }
}
