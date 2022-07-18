using System;
using System.Collections.Generic;

#nullable disable

namespace BookMyMovie.Models
{
    public partial class Smovie
    {
        public int Id { get; set; }
        public string SelectMovie { get; set; }
        public string SelectTheater { get; set; }
        public int? SelectSeats { get; set; }
        public string SelectGender { get; set; }
        public string SelectAge { get; set; }
        public DateTime? SelectDate { get; set; }
        public TimeSpan? SelectTime { get; set; }
    }
}
