using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class StatusGuarantee
    {
        [Key()]
        public int status_guarantee_id { set; get; }
        public string? status_name { set; get; }


        public int product_guarantee_id { set; get; }
        [ForeignKey("product_guarantee_id")]
        public virtual ProductGuarantee? ProductGuarantee { set; get; }
    }
}
