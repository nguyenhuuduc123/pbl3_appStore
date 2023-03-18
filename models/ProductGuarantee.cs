using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class ProductGuarantee
    {
        [Key()]
        public int product_guarantee_id { set; get; }
        public string? product_name { set; get; }
        public DateTime date_recieve { set; get; }
        public DateTime date_pay { set; get; }
        public string? content { set; get; }
        public double money_pay { set; get; }

        public int product_id { set; get; }

        public virtual Item? item { set; get; }  

        public virtual StatusGuarantee? status { set; get; }
    }
}
