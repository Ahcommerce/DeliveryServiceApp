using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.KitchenDb
{
    public class Kitchen
    {
        [Key]
        public int KitchenId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string Phone { get; set; }

    }
}
