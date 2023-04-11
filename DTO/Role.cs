using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Role
    {
        [Key()]
        public int role_id {  get; set; }
        public string? name_role { get; set; }   
        public virtual Person? person { get; set; }  
    }
}
