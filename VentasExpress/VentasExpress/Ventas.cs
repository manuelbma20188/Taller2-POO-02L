using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasExpress
{
    public partial class Ventas : Form
    {
        public Products products;
        public Ventas(Products pro)
        {
            products = pro;
            InitializeComponent();
        }

        
        public string valor;

        //public static List<Products> listProducts = new List<Products>(); //list of my class Products                
        private int count=0;
        private List<Products> Selected = new List<Products>();

        //method to fill the list of the products                

        private void Ventas_Load(object sender, EventArgs e)
        {
            products.FillListProducts();            
            //--FillListProducts();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = products.listProducts;
            //any selected row at the beginning
            dgvDatos.CurrentCell.Selected = false;            
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string cadena = txtSearch.Text.ToString();
            List<string> list = new List<string>();
            list = cadena.Split(',').ToList();
            //1,2,3,5,8,9
            for (int i = 0; i < list.Count(); i++)
            {
                if ((i+1) %2 !=0)
                {
                    string id = list[i];
                    int cantidad = Convert.ToInt32(list[i + 1]);

                    var selectedProduct = (products.listProducts.Where(att => att.Code == id).Select(att => att).FirstOrDefault());                    
                    selectedProduct.Quantity -= cantidad;
                }                
            }
            txtSearch.Text = "";
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = products.listProducts;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
