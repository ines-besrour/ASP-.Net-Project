using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CinemaWeb.Models;

namespace CinemaWeb.Data
{
    public class CinemaContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        static public int c = 0;
        private static CinemaContext instance = null;
        public CinemaContext(DbContextOptions o) : base(o)
        {
            c++;
        }
        static public CinemaContext Instantiate_CinemaContext()
        {
            if (instance == null)
            {
                var optionBuilder = new DbContextOptionsBuilder<CinemaContext>();
                optionBuilder.UseSqlite($"Data Source=DB.db");
                instance = new CinemaContext(optionBuilder.Options);
            }

            return instance;
        }

    }
}


