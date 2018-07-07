using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.KitchenDb
{
    public class KitchenDbContext: DbContext
    {
        public KitchenDbContext() : base("KitchenDbContext")
        {
        }
        public KitchenDbContext(string conString) : base(conString)
        {
        }
        public DbSet<Kitchen> Kitchens { get; set; }
    }
}
