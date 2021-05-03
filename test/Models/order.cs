using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Order
    {
        public string id { get; set; }
        public string idCustomer { get; set; }

        public string idCart { get; set; }
        public string dateTime { get; set; }
        public double transportFee { get; set; }
        public double totalOrder { get; set; }
        public double totalCost { get; set; }
        public double discout { get; set; }

        public int statusPay { get; set; }

        public int statusOrder { get; set; }

        public int payMethod { get; set; } 

        public int amout { get; set; }

    }
}