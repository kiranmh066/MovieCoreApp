using Microsoft.EntityFrameworkCore;
using MovieEntity.Data;
using MovieEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieEntity.BookMyShow
{
    public class MovieOperations
    {
        MovieDbContext db=null;
        public string AddMovie(Movie movie)
        {
            db = new MovieDbContext();
            db.movies.Add(movie);
            db.SaveChanges();

            return "Saved";
        }
        public string UpdateMovie(Movie movie)
        {
           
            db=new MovieDbContext();
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();

            return "Updated";
        }
        public string DeleteMovie(int movieId)
        {
           
            db = new MovieDbContext();
            Movie movieObj= db.movies.Find(movieId);
            db.Entry(movieObj).State = EntityState.Deleted;
            db.SaveChanges();

            return "Deleted";
        }
        public List<Movie> ShowAllMovie()
        {
           
            db = new MovieDbContext();
            List<Movie> movieList = db.movies.ToList();

            return movieList;
        }

        public List<Movie> ShowMovieByType(string type)
        {
            db = new MovieDbContext();
            List<Movie> movieList =db.movies.ToList();

            //Linq query- select * from movie where movietype='type'
            var result = from movies in movieList
                         where movies.MovieType == type
                         select new Movie
                         {
                             Id= movies.Id,
                             Name=movies.Name,
                         };
            List<Movie> movieResult= new List<Movie>();
            foreach (var item in result) // Linq Query execution
            {
                movieResult.Add(item);

            }
            return movieResult;
        }

        public Movie ShowMovieById(int movieId)
        {
           
            db = new MovieDbContext();
            Movie movie = db.movies.Find(movieId);

            return movie;
        }

    }
}
