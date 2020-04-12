using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace OrderService
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        
        //[HttpGet]
        //public ActionResult<IEnumerable<Order>> Get()
        //{
        //    return DataContext.OrderDataContext.GetOrderList().ToList();
        //}

        [HttpGet("{id}")]
        public IEnumerable<Order> Get(int id)
        {
            return DataContext.OrderDataContext.GetOrderItemByUserId(id);
        }
    }
}
