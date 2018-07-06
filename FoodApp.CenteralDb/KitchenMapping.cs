using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.CenteralDb
{
    public class KitchenMapping
    {
        [Key]
        public int KitchenMappingId { get; set; }
        public int KitchenId { get; set; }
        public string KitchenOwnerEmail { get; set; }
        public string DbInstance { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
