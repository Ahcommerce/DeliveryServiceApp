using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.CustomerDb
{
    public class CustomerDbContext:DbContext
    {
        public CustomerDbContext() : base("CustomerDbContext")
        {
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
