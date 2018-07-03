using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.CenteralDb
{
   public class CustomerMapping
    {
        [Key]
        public int CustomerMappingId { get; set; }

        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string DbInstance { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

    }
}
