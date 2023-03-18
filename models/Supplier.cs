using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Supplier
    {
        [Key()]
        public int supplier_id { get; set; }
        public string? supplier_name { get; set; }
        public string? supplier_phonenumber { get; set; }
        public string? supplier_address { get; set; }

        // item relationship

        public int item_id { set; get; }
        [ForeignKey("item_id")]
        public virtual Item? item { set; get; }
    }
}
