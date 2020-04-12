using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       static DataContext.UserDataContext db;

        static UserController()
        {
            db = new DataContext.UserDataContext();
            try
            {
                db.Users.Add(new User() { UserId = 1, Name = "Ajay", Age = 23, Email = "ajay@gmail.com" });
                db.Users.Add(new User() { UserId = 2, Name = "Himanshu", Age = 21, Email = "himanshu@gmail.com" });
                db.SaveChanges();
            }catch(Exception ex)
            {

            }
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
          return db.Users.Find(id);
        }
    }
}
