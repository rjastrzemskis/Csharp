using System;

namespace Exercise4
{
    class Movie
    {
        public string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }
        
        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public void MovieInfo()
        {
            Console.WriteLine("Movie title: " + _title + ", studio: " + _studio + ", rating: " + _rating);
        }

        public string ReturnRating()
        {
            return _rating;
        }

        public static Movie[] GetPG(Movie[] movie)
        {
            Movie[] pgMovie = new Movie[movie.Length];

            int pgMovieCount = 0;
            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].ReturnRating() == "PG")
                {
                    pgMovie[pgMovieCount] = movie[i];
                    pgMovieCount++;
                }
            }
            return pgMovie;
        }
    }
}
