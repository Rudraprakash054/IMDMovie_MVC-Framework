using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace IMDMovie.Models
{
    public static class Data
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IMDMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<IMDMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Movie_Name= "Hello",
                        Year_of_Release= 1234,
                        plot= "It is new movie",
                        cast = "hii"
                    },

                    new Movie
                    {
                        Movie_Name= "Hello",
                        Year_of_Release= 1234,
                        plot= "It is new movie",
                        cast = "hii",
                    },

                    new Movie
                    {
                        Movie_Name= "Hello",
                        Year_of_Release= 1234,
                        plot= "It is new movie",
                        cast = "hii",
                    },

                    new Movie
                    {
                        Movie_Name= "Hello",
                        Year_of_Release= 1234,
                        plot= "It is new movie",
                        cast = "hii",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}