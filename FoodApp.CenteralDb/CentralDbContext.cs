using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.CenteralDb
{
    public class CentralDbContext:DbContext
    {
        public CentralDbContext() : base("CentralDbContext")
        {
        }
        public DbSet<KitchenMapping> KitchenMappings { get; set; }
        public DbSet<CustomerMapping> CustomerMappings { get; set; }
    }
}
