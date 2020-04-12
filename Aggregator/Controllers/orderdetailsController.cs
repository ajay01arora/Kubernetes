using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aggregator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class orderdetailsController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<string> GetAsync(int id)
        {
            var client = new HttpClient();

            var list = Environment.GetEnvironmentVariables();

            string userHttp, orderHttp;

            if (list.Contains("UserService"))
            {
                userHttp = Environment.GetEnvironmentVariable("UserService") + "/user/" + id.ToString();
                orderHttp = Environment.GetEnvironmentVariable("OrderService") + "/order/" + id.ToString();
            }
            else
            {
                userHttp = "http://userservice/user/" + id.ToString();
                orderHttp = "http://orderservice/order/" + id.ToString();
            }


            var content = await client.GetStringAsync(userHttp);

            var content1 = await client.GetStringAsync(orderHttp);
            string result = content + "\n" + content1;
            return result;
        }
    }
}
