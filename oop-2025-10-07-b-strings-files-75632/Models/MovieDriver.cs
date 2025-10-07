using oop_2025_10_07_b_strings_files_75632.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files_75632.Models
{
    internal class MovieDriver
    {
        public static void Run()
        {
            List<Movie> movies = MovieRepository.GetAllMovies();

            foreach (Movie movie in movies)

            {  Console.WriteLine(movie.ToString());
            
            }
        }
    }
}
