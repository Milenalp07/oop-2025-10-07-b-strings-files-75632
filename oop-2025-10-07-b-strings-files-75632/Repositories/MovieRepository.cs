using oop_2025_10_07_b_strings_files_75632.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files_75632.Repositories
{
    public static class MovieRepository
    {
        public static List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>
        {
            new Movie("Inception", "Christopher Nolan", 2010, "Sci-Fi", 8.8),
            new Movie("The Shawshank Redemption", "Frank Darabont", 1994, "Drama", 9.3),
            new Movie("The Godfather", "Francis Ford Coppola", 1972, "Crime", 9.2),
            new Movie("Pulp Fiction", "Quentin Tarantino", 1994, "Crime", 8.9),
            new Movie("The Matrix", "The Wachowskis", 1999, "Sci-Fi", 8.7)
        };

            return movies;
        }
    }
}
