using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Invoice
    {
        [Key()]
        public int invoice_id { set; get; }
        public DateTime date { set; get; }
        public string? type { set; get; }

       
        public virtual ICollection<Item>? items { set; get;}

    }
}
