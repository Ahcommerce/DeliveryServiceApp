using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.CenteralDb
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Zip { get; set; }
        public string LocationName { get; set; }

    }
}
