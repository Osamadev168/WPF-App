using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WpfApp.Models;
namespace WpfApp.Data
{
    internal class Database : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R3QCJ3S;Database=WPF;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        
        }
        public DbSet<User> Users { get; set; }
    }
}
