using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class TopSellingRRatedFilms
    {
        public string FilmTitle { get; set; }
        public string Rating { get; set; }
        public short? Length { get; set; }
        public decimal? RentalSales { get; set; }
    }
}
