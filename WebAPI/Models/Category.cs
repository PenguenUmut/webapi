using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Category
    {
        public int id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
    }
}