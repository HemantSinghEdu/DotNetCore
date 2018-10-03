using System;
using System.Collections.Generic;

namespace MovieApp.Entities
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public float? Price { get; set; }
    }
}
