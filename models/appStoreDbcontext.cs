using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class appStoreDbcontext : DbContext
    {
       private static appStoreDbcontext instance  = new appStoreDbcontext();

        public static appStoreDbcontext _instance
        {
            get { return instance; }
           
        }
        
        private appStoreDbcontext() {
            Console.WriteLine(ConfigurationManager.AppSettings["connectionString"]);
       }
       // private readonly string connectionStrings = @"Data Source=localhost,1433;Initial Catalog=appdb1;User ID=SA;Password=password123;Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true;";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["connectionString"]).UseLazyLoadingProxies();
            
           // string hashpassword = BCrypt.Net.BCrypt.HashPassword("ssgdg");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasOne(r => r.person).WithOne(p => p.role).HasForeignKey<Person>(p => p.role_id);
            
        }
        public virtual DbSet<Person> persons { set; get; } 

        public virtual DbSet<Item> items { set; get; }
        public virtual DbSet<Invoice> invoices { set; get; }
        public virtual DbSet<Customer> customers { set; get; }
        public virtual DbSet<ProductGuarantee> productGuarantees { set; get; }
        public virtual DbSet<Role> roles { set; get; }

        public virtual DbSet<Staff> staffs { set; get; }
        public virtual DbSet<StatusGuarantee> statusGuarantees { set; get; }

        public virtual DbSet<Supplier> suppliers { set; get; }
    }
}
