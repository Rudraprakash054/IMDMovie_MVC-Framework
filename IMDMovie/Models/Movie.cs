using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IMDMovie.Models
{
    public class Movie
    {
        public string Movie_Name{get; set;}
        public int Year_of_Release{get; set;}
        public string plot{get; set;}
        public string cast{get; set;}
    }
}