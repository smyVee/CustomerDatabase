using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerDatabase.Models
{
    /* Written by Paul Smyth
     * Date 31/01/2018
     * Version 1.0
     */
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Text)]
        public string Town { get; set; }

        [Required]
        [StringLength(3)]
        [DataType(DataType.Text)]
        public string State { get; set; }

        [Required(ErrorMessage ="Enter a Postcode between 0800 and 7999")]     
        [DataType(DataType.PostalCode)]
        [RegularExpression("([0-9][0-9][0-9][0-9])")]
        [StringLength(4)]
        public string Postcode { get; set; }
    }
}
