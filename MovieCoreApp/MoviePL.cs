using MovieEntity.BookMyShow;
using MovieEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCoreApp
{
    public class MoviePL
    {
        public void MenuPL()
        {
            Console.WriteLine("Enter 1 to Add Movie \n" +
                "Enter 2 to Update Movie \n" +
                "Enter 3 to Delete Movie \n "+
                "Enter 4 to Show All Movie \n" +
                "Enter 5 to Show Movie By Id \n"+
                "Enter 6 to Show Movie By Type \n" +
                "Enter  to Exit"
                );

            int enter=Convert.ToInt32(Console.ReadLine());
            MoviePL moviePLObj = new MoviePL();

            switch(enter)
            {
                case 1:moviePLObj.AddMoviePL();
                    moviePLObj.MenuPL();
                    break;
                case 2:moviePLObj.UpdateMoviePL();
                    moviePLObj.MenuPL();
                    break;
                case 3:moviePLObj.DeleteMoviePL();
                    moviePLObj.MenuPL();
                    break;
                case 4:moviePLObj.ShowAllMoviesPL();
                    moviePLObj.MenuPL();
                    break;
                case 5:moviePLObj.ShowMovieByIdPL();
                    moviePLObj.MenuPL();
                    break;
                case 6:
                    moviePLObj.ShowMovieByTypePL();
                    moviePLObj.MenuPL();
                    break;
                default:Console.WriteLine("Better Luck Next Time :)");
                    break;
            }
        }
        public void AddMoviePL()
        {
            MovieOperations movieOperationsObj = new MovieOperations();
            Movie movieObj = new Movie();

            Console.WriteLine("Enter MovieName: ");
            movieObj.Name=Console.ReadLine();
            Console.WriteLine("Enter Movie Description: ");
            movieObj.MovieDesc = Console.ReadLine();
            Console.WriteLine("Enter Movie Type: ");
            movieObj.MovieType = Console.ReadLine();

            string msg = movieOperationsObj.AddMovie(movieObj);
            Console.WriteLine(msg);
        }

        public void UpdateMoviePL()
        {
            MovieOperations movieOperationsObj = new MovieOperations();
            Movie movieObj = new Movie();

            Console.WriteLine("Enter MovieId: ");
            movieObj.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MovieName: ");
            movieObj.Name = Console.ReadLine();
            Console.WriteLine("Enter Movie Description: ");
            movieObj.MovieDesc = Console.ReadLine();
            Console.WriteLine("Enter Movie Type: ");
            movieObj.MovieType = Console.ReadLine();

            string msg = movieOperationsObj.UpdateMovie(movieObj);
            Console.WriteLine(msg);
        }

        public void DeleteMoviePL()
        {

            MovieOperations movieOperationsObj = new MovieOperations();
            //Movie movieObj = new Movie();

            Console.WriteLine("Enter MovieId: ");
            int movieId = Convert.ToInt32(Console.ReadLine());
           
            string msg = movieOperationsObj.DeleteMovie(movieId);
            Console.WriteLine(msg);
        }


        public void ShowAllMoviesPL()
        {
            MovieOperations movieOperationsObj = new MovieOperations();
            List<Movie> movieList = movieOperationsObj.ShowAllMovie();

            foreach(var item in movieList)
            {
                Console.WriteLine("Id: "+item.Id);
                Console.WriteLine("Name: " +item.Name);
                Console.WriteLine("Description: " + item.MovieDesc);
                Console.WriteLine("Type: " + item.MovieType);
            }
        }

        public void ShowMovieByIdPL()
        {
            MovieOperations movieOperationsObj=new MovieOperations();
            Console.WriteLine("Enter MovieId: ");
            int movieId = Convert.ToInt32(Console.ReadLine());
            Movie movie= movieOperationsObj.ShowMovieById(movieId);
            
            Console.WriteLine(movie.Name);
            Console.WriteLine(movie.MovieDesc);
            Console.WriteLine(movie.MovieType);
        }

        public void ShowMovieByTypePL()
        {
            MovieOperations movieOperationsObj = new MovieOperations();
            Console.WriteLine("Enter MovieType: ");
            string movieType = Console.ReadLine();
            List<Movie> movieList  = movieOperationsObj.ShowMovieByType(movieType);

            foreach (var item in movieList)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
/*                Console.WriteLine("Description: " + item.MovieDesc);
                Console.WriteLine("Type: " + item.MovieType);*/
            }

            /*Console.WriteLine(movie.Name);
            Console.WriteLine(movie.MovieDesc);
            Console.WriteLine(movie.MovieType);*/


        }
    }
}
