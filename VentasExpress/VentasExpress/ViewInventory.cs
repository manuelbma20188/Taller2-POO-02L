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
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
        }

        private List<Products> listProducts = new List<Products>(); //list of my class Products                
        private int count;

        //method to fill the list of the products
        private void FillListProducts()
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
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listProducts;
        }
        
        private List<Products> SearchProducts(string wordParam)
        {
            
            if (wordParam == "TODOS")
            {
                FillListProducts();
                count++;
                dgvDatos.DefaultCellStyle.ForeColor = Color.Black;
                if(count > 1)
                {
                    listProducts.Clear();
                    FillListProducts();
                    dgvDatos.CurrentCell.Selected = false;
                }
            }
            else
            {                
                int value = 0;
                if (int.TryParse(txtSearch.Text, out value))
                {
                    var result = from s in listProducts
                                 where s.Code == (wordParam)
                                 select s;
                    foreach (var student in result)
                        MessageBox.Show("Producto seleccionado: " + student.ProductName);
                }
                else
                {
                    var result = from s in listProducts
                                 where s.ProductName == (wordParam)
                                 select s;
                    foreach (var student in result)
                        MessageBox.Show("Producto seleccionado: " + student.ProductName);
                }
            }
            return listProducts;
        }
        
        private void btnViewData_Click(object sender, EventArgs e)
        {            
            string value = txtSearch.Text.ToString();                        
            dgvDatos.DataSource = SearchProducts(value);
            
            foreach (DataGridViewRow Row in dgvDatos.Rows) 
            {                
                string Valor = Convert.ToString(Row.Cells["Code"].Value);
                string Valor2 = Convert.ToString(Row.Cells["ProductName"].Value);
                
                if (Valor == this.txtSearch.Text || Valor2 == txtSearch.Text)
                {                    
                    Row.Selected = true; 
                    dgvDatos.DefaultCellStyle.BackColor = Color.White;
                    dgvDatos.DefaultCellStyle.ForeColor = Color.White;
                }
            }            
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {            
            dgvDatos.DataSource = SearchProducts(txtSearch.Text);
            //any selected row at the beginning
            dgvDatos.CurrentCell.Selected = false;            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
