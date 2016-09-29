using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You Must Enter Name")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Must be beetwen 3 and 60 character")]
        public string Name { get; set; }

        [Display(Name = "Pub Date")]
        [DataType(DataType.Date)]
        public DateTime PubDate { get; set; }

        [Range(1, 100, ErrorMessage = "Must be Beetwen 1$ and 100$")]
        public decimal Price { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You Must Enter Genre")]
        public string Genre { get; set; }
    }
}