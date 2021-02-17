using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_Joisah_Sarles.Models
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        [Required]
        public string title { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public string publisher { get; set; }

        [Required]
        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$",
            ErrorMessage =" ISBN in not in the required format of ###-##########")]
        public string isbn { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public double price { get; set; }




    }
}
