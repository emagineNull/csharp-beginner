using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            string maxRating = string.Empty;
            string minRating = string.Empty;

            double maxMovieRating = 0;
            double minMovieRating = int.MaxValue;
            double ratingSum = 0;
            string movie = string.Empty;
            double rating = 0;

            for (int i = 1; i <= movies; i++)
            {
                movie = Console.ReadLine();
                rating = double.Parse(Console.ReadLine());
                if (maxMovieRating < rating)
                {
                    maxRating = movie;
                    maxMovieRating = rating;
                }
                if (minMovieRating > rating)
                {
                    minRating = movie;
                    minMovieRating = rating;
                }
                ratingSum += rating;
            }

            double averageRating = ratingSum / movies;

            Console.WriteLine($"{maxRating} is with highest rating: {maxMovieRating:f1}");
            Console.WriteLine($"{minRating} is with lowest rating: {minMovieRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
