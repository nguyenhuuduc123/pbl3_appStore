
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Category

    {
        [Key()]
        public int id { get; set; }
        public string? name { get; set; }


        public int item_id { get; set; }
        [ForeignKey("item_id")]
        public virtual ICollection<Item>? item { get; set; }
    }
}
