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
        
        private void Ventas_Load(object sender, EventArgs e)
        {
            //filling dgv
            products.FillListProducts();                        
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = products.listProducts;
            //any selected row at the beginning
            dgvDatos.CurrentCell.Selected = false;            
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string values = txtSearch.Text.ToString();
            //we create a list that is saving the values
            List<string> list = new List<string>();
            list = values.Split(',').ToList();
            //1,2,3,5,8,9 [xample]
            for (int i = 0; i < list.Count(); i++)
            {
                //taking numbers in odd positions
                if ((i+1) %2 !=0)
                {
                    //taking only id's
                    string id = list[i];
                    //taking quantities
                    int quantity = Convert.ToInt32(list[i + 1]);
                    //searching products
                    var selectedProduct = (products.listProducts.Where(att => att.Code == id).Select(att => att).FirstOrDefault());                    
                    selectedProduct.Quantity -= quantity; //operating
                }                
            }
            txtSearch.Text = "";
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = products.listProducts;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
