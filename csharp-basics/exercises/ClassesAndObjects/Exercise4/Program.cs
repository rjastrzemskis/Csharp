using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG13");
            Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] movieList = new Movie[3];
            movieList[0] = movie1;
            movieList[1] = movie2;  
            movieList[2] = movie3;

            movie1.MovieInfo();
            movie2.MovieInfo();
            movie3.MovieInfo();

            Movie[] returnMovies = Movie.GetPG(movieList);
            for (int i = 0; i < returnMovies.Length; i++)
            {
                if (returnMovies[i] != null)
                {
                    Console.WriteLine("You can go to movie " + returnMovies[i]._title.ToString() + " without any PG limitation.");
                }
            }
            Console.ReadKey();
        }
    }
}