using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files_75632.Models
{
    public class Movie
    {
        // 5 Properties
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Constructor
        public Movie(string title, string director, int year, string genre, double rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = ReleaseYear;
            Genre = genre;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} ({ReleaseYear}) - {Genre} - Directed by {Director} - Rating: {Rating}/10";
        }
    }
}
