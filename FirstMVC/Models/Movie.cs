using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }
        [Required]
        public int InStock { get; set; }
    }
}