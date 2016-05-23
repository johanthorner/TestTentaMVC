using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTentaMVC.Models
{
    public class Artist
    {
        [Required]
        public int ID { get; set; }
        [Range(minimum:0, maximum:120)]
        public int Age { get; set; }
        public string Band { get; set; }
        public List<Song> Songs { get; set; }

    }
}