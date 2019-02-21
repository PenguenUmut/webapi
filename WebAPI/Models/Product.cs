using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int version { get; set; }
        public decimal price { get; set; }
        public bool stock { get; set; }
        public string desc { get; set; }
        public Category category { get; set; }
    }
}