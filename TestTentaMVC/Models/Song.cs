using System;
using System.ComponentModel.DataAnnotations;

namespace TestTentaMVC.Models
{
    public class Song
    {
        [Required]
        public int ID { get; set; }
        [StringLength(maximumLength:100, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(minimum:0, maximum:20)]
        public double Duration { get; set; }
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Genre { get; set; }

    }
}