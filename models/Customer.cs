using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Customer
    {
        [Key()]
        public int customer_id {  get; set; }
        public string? phonenumber { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }


        public int invoice_id { set; get; }
        [ForeignKey("invoice_id")]
        public virtual Invoice? invoice { get; set; }
    }
}
