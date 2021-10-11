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
        public Products products;
        public ViewInventory(Products pro)
        {
            products = pro;
            InitializeComponent();
        }                
        public List<Products> PersonaRecibe = new List<Products>(); //list that is gonna receive the values

        //function to search products
        private List<Products> SearchProducts(string wordParam)
        {            
            //comparing the param if is equal to "todos or TODOS"
            if (wordParam == "todos")
            {
                this.Hide();
                this.Show();       
                //validation if the grid is empty of values
                if(dgvDatos.RowCount !=0)
                //by default, row 1 selects by herself, so we desactivate that option
                dgvDatos.CurrentCell.Selected = false;                
                dgvDatos.DefaultCellStyle.ForeColor = Color.Black;                
            }
            else
            {                
                //comparing if the param is a number [code product]
                int value = 0;
                if (int.TryParse(txtSearch.Text, out value))
                {       
                    //with linq, we search if a record is equal to the param
                    var result = from s in PersonaRecibe
                                 where s.Code == (wordParam)
                                 select s;
                    foreach (var student in result)
                        MessageBox.Show("Producto seleccionado: " + student.ProductName);
                        dgvDatos.DefaultCellStyle.BackColor = Color.White;
                        dgvDatos.DefaultCellStyle.ForeColor = Color.White;                    
                }                
                else
                {
                    //we search if a record is equal to the param[product name]
                    var result = from s in PersonaRecibe
                                 where s.ProductName == (wordParam)
                                 select s;
                    foreach (var student in result)
                        MessageBox.Show("Producto seleccionado: " + student.ProductName);
                        dgvDatos.DefaultCellStyle.BackColor = Color.White;
                        dgvDatos.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            //we return the list
            return products.listProducts;
        }
        
        private void btnViewData_Click(object sender, EventArgs e)
        {            
            string value = txtSearch.Text.ToString();

            dgvDatos.DataSource = null;
            //calling the function, passing the parameter
            dgvDatos.DataSource = SearchProducts(value.ToLower());            

            //iterating the rows
            foreach (DataGridViewRow Row in dgvDatos.Rows) 
            {                
                string value1 = Convert.ToString(Row.Cells["Code"].Value);
                string value2 = Convert.ToString(Row.Cells["ProductName"].Value);
                Row.Selected = false;
                //if the values are equal to txt's
                if (value1 == this.txtSearch.Text || value2.ToUpper() == txtSearch.Text || value2.ToLower() == txtSearch.Text)
                {
                    Row.Selected = true;
                    dgvDatos.DefaultCellStyle.BackColor = Color.White;
                    dgvDatos.DefaultCellStyle.ForeColor = Color.White;                    
                }
            }            
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            //iterating 
            foreach(var dato in PersonaRecibe)
            {
                Products p = new Products();
                dgvDatos.DataSource = p.listProducts;                
            }            

            dgvDatos.DataSource = SearchProducts(txtSearch.Text);            
            if (dgvDatos.RowCount != 0)
            {
                dgvDatos.CurrentCell.Selected = false;
            }            

            this.Hide();
            this.Show();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
