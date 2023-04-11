
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Login
    {
        [Key()]
        public int id {  get; set; }
        public string? email { get; set; }
        public string? password { get; set; }

        public virtual Person? person { get; set; }
    }
}
