using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Demo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter customer's name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Display(Name="Is cool")]
        public bool IsCool { get; set; }
        public List<int> Counts { get; set; }
    }
}