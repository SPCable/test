using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Cart
    {
        public string idProduct { get; set; }
        public string idCount { get; set; }
        [Key]
        public string idCart { get; set; }
    }
}