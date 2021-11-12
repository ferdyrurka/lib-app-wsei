using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lib_app_wsei.Models;

namespace lib_app_wsei.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
