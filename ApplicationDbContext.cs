using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NavistarWebApp.Data;

namespace NavistarWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NavistarWebApp.Data.DepartmentPage> DepartmentPage { get; set; }
        public DbSet<NavistarWebApp.Data.AttritionPage> AttritionPage { get; set; }
        public DbSet<NavistarWebApp.Data.AdminPage> AdminPage { get; set; }
        public DbSet<NavistarWebApp.Data.SLTPage> SLTPage { get; set; }
        public DbSet<NavistarWebApp.Data.AduitTable> AduitTable { get; set; }
        public DbSet<NavistarWebApp.Data.Employees> Employees { get; set; }
    }
}
