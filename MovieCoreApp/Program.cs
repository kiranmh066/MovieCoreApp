using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCoreApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoviePL moviePLObj = new MoviePL();
            moviePLObj.MenuPL();

            /*List<int> values = new List<int>()
            {
                23,34,56,676,34,67,32,10,5
            };

            var result=from obj in values
                       orderby obj descending
                       where obj>50
                       select obj;

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }*/

        }
    }
}
