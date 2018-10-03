using System;
using System.Collections.Generic;

namespace testproject01.Entities
{
    public partial class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public float? Price { get; set; }
    }
}
