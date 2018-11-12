using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laboration1.Models
{
    public class PSA
    {
        [Required]
        [Display(Name ="De tre första bokstäverna")]
        [StringLength(3)]
        [RegularExpression(@"(ASP)", ErrorMessage ="Du MÅSTE skriva 'ASP'")]
        public string First { get; set; }

        [Required]
        [Display(Name = "Det där i mitten")]
        [RegularExpression(@"(.)", ErrorMessage = "Du MÅSTE skriva '.'")]
        [StringLength(1)]
        public string Mitten { get; set; }

        [Required]
        [Display(Name ="De tre sista bokstäverna")]
        [StringLength(3)]
        [RegularExpression(@"(NET)", ErrorMessage = "Du MÅSTE skriva 'NET'")]
        public string Last { get; set; }

        public PSA() { }
    }
}