using oop_2025_10_07_b_strings_files_75632.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files_75632.Drivers
{
    public static class FileDriver
    {
        public static void Run()
        {
            Console.WriteLine("File Driver Running...");
            WriteTextFile();
            WriteMoviesToFile();
        } // end of Run()

        public static void WriteTextFile()
        {

            string[] lines = { "First line", "Second line", "Third line", "Fourth Line" };
            string fileToWrite = "../../../Documents/output.txt";
            File.WriteAllLines(fileToWrite, lines);
            Console.WriteLine($"Wrote to file: {fileToWrite}");

        }

        public static void WriteMoviesToFile()
        {



            var movies = MovieRepository.GetAllMovies();
            string fileToWrite = "../../../Documents/movies.txt";
            List<string> movieLines = new List<string>();
            foreach (var movie in movies)
            {
                movieLines.Add($"{movie}");
            }
            File.WriteAllLines(fileToWrite, movieLines);
            Console.WriteLine($"Wrote to file: {fileToWrite}");

        }
    }
}
