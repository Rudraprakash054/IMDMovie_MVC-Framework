using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace IMDMovie.Models
{
    public class IMDMovieContext : DbContext
    {
        public IMDMovieContext (DbContextOptions<IMDMovieContext> options) : base(options)
        {
        }
        public DbSet<IMDMovie.Models.Movie> Movie{get; set;}
    }
}