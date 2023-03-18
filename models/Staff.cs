using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Staff
    {
        [Key()]
        public int? staff_id {  get; set; }
        public string? position { get; set; }

        public double salary { get; set; }
        public int product_guarantee_id { get; set; }

        public virtual ICollection<Invoice>? Invoices { get; set; }
    }
}
