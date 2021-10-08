using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    class Products
    {
        //atributes
        private string code;
        private string productName;
        private double price;
        private int quantity;
        public string Code { get => code; set => code = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
