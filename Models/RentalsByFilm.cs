using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class RentalsByFilm
    {
        public string FilmTitle { get; set; }
        public int? TotalRentals { get; set; }
    }
}
