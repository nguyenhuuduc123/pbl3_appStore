using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int role_id { get; set; }
        public virtual Role? role { get; set; }
    }
}
