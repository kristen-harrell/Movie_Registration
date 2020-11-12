using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Registration.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="The maximum number of characters is 50")]
        public string Title { get; set; }
        public string Genre { get; set; }
        [Range(1880, 2020, ErrorMessage ="The earliest year you can enter is 1880" )]
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

        //getting this ready so that I can put these in a table or on a list
        //public Movie(int id, string title, string genre, int year, string actors, string directors )
        //{
        //    ID = id;
        //    Title = title;
        //    Genre = genre;
        //    Year = year;
        //    Actors = actors;
        //    Directors = directors;
        //}
    }
}
