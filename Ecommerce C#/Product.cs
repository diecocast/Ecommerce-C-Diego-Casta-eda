using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_C_
{
    public class Product
    {
        private int id;
        private string description;
        private decimal price;
        private decimal total;
        private int stock;
        private int user_id;

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int Stock { get; set; }
        public int User_Id { get; set; }

    }
}
