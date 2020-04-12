    using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.DataContext
{
    public class UserDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"data source=AJAY3150060\LUTRON2017; initial catalog=UserMicroService; persist security info=True; user id=sa; password=Lutr0n@1703800293;");
            optionsBuilder.UseSqlServer(@"Data Source=35.232.25.233,1433;Network Library=DBMSSOCN;Initial Catalog=UserMicroService;User ID=sa;Password=Ajay@110125;");
        }
    }
}
