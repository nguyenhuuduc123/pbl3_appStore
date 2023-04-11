using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Person
    {
        [Key()]
        public int person_id { get; set; }
        public string? fullname { get; set; }
        public bool gender { get; set; }
        public string? address { get; set; }
        public DateTime date_of_birth { get; set; }
        public string? phone_number { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }


        public string? rePassword { get; set; }
        public int role_id { get; set; }
        [ForeignKey("role_id")]
        public virtual Role? role { get; set; }
        public int login_id { get; set; }
        [ForeignKey("login_id")]
        public virtual Login? Login { get; set; }
        public virtual Invoice? Invoice { get; set; }
        public virtual ICollection<Item>? Item { get; set; }

    }
}
