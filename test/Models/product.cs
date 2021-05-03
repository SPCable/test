using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Product
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){id = "1", categoryId="1", name = "Thịt bò" , status = false},
            new Product(){id = "2", categoryId="2", name = "Thịt cừu", status = false},
            new Product(){id = "3", categoryId="3", name = "Thịt gà", status = false},
            new Product(){id = "4", categoryId="4", name = "Thịt dê", status = false},              
        };
        public string id { get; set; }
        public string name { get; set; }

        public string categoryId { get; set; }

        public int amout { get; set; }

        public int barcode { get; set; }

        public string desc { get; set; }

        public string img { get; set; }

        public string updateDay { get; set; }

        public double price { get; set; }

        public double wholesalePrice { get; set; }

        public double importPrice { get; set; }

        public double costPrice { get; set; }

        public double tax { get; set; }

        public bool status { get; set; }

    }
}