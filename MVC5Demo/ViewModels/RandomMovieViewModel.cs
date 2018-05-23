using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Demo.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Customer> Customers{ get; set; }
        public Movie Movie { get; set; }
    }
}