using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineTicariOtomasyonMVC.Models.Classes
{
    // Bunun üzerinden tabloları sql e yansıtıyoruz.
    public class Context:DbContext
    {// Admin tablosu SQL Veritabanında Admins olarak görünecektir.
        public DbSet<Admin>  Admins { get; set; }
        public DbSet<Current>  Currents { get; set; }
        public DbSet<Department>  Departments { get; set; }
        public DbSet<Bill_Item>  Bill_Items { get; set; }
        public DbSet<Bill>  Bills { get; set; }
        public DbSet<Expense>  Expenses { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Staff>  Staffs { get; set; }
        public DbSet<SalesMovement>  SalesMovements { get; set; }
        public DbSet<Product>  Products { get; set; }
    }
}