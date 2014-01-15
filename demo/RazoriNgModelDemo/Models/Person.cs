using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RazoriNgModelDemo.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        [MaxLength(100)]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        [MaxLength(100)]
        public string AddressLine2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        [MaxLength(2)]
        public string State { get; set; }

        [Required]
        [Display(Name = "10 Digit Zip Code")]
        [MaxLength(10)]
        [MinLength(5)]
        public string Zip { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Agency Phone")]
        public string Phone { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Agency Fax")]
        public string Fax { get; set; }
    }
}