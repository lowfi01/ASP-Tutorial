using ASP_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Tutorial.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}