using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Class15Demo.Models;

namespace Class15Demo.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(30,400)]
        public int RunTime { get; set; }

        [Required]
        public string Genre { get; set; }

        [Display(Name = "Starring")]
        [Required]
        public string LeadStar { get; set; }
    }
}
