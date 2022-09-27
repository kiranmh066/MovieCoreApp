using Microsoft.EntityFrameworkCore;
using MovieEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieEntity.Data
{
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> movies { get; set; }
        public DbSet<Theatre> theatre { get; set; }
        public DbSet<ShowTiming> showTiming { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2164; Initial Catalog = MyMovieShow; Integrated Security=True;") ;
        }
    }
}
