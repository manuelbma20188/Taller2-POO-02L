using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    public class Products
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

        public  List<Products> listProducts = new List<Products>(); //list of my class Products                

        public void FillListProducts()
        {
            listProducts.Add(new Products { Code = "1", ProductName = "huevos", Price = 0.10, Quantity = 30 });
            listProducts.Add(new Products { Code = "2", ProductName = "pollo", Price = 5, Quantity = 10 });
            listProducts.Add(new Products { Code = "3", ProductName = "aceite", Price = 3, Quantity = 50 });
            listProducts.Add(new Products { Code = "4", ProductName = "fosforos", Price = 0.50, Quantity = 200 });
            listProducts.Add(new Products { Code = "5", ProductName = "dulces", Price = 0.80, Quantity = 500 });
            listProducts.Add(new Products { Code = "6", ProductName = "margarina", Price = 0.30, Quantity = 30 });
            listProducts.Add(new Products { Code = "7", ProductName = "jabón", Price = 2.25, Quantity = 25 });
            listProducts.Add(new Products { Code = "8", ProductName = "carne", Price = 2.75, Quantity = 35 });
            listProducts.Add(new Products { Code = "9", ProductName = "gaseosa", Price = 1.80, Quantity = 200 });
            listProducts.Add(new Products { Code = "10", ProductName = "desechables", Price = 3.25, Quantity = 900 });          
        }

    }
}
