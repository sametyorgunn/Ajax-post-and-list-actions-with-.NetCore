using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace jquery.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;username=root;database=ajax_db;password=yorgun.1292;port=3306");

        }
        public DbSet<kisiler>kisilers { get; set; }
    }
}
