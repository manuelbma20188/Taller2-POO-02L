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
        private int count;
        public List<Products> PersonaRecibe = new List<Products>(); //creación de una lista que reciba        

        //function to fill the list of the products
        private List<Products> SearchProducts(string wordParam)
        {
            count = 0;
            if (wordParam == "todos")
            {
                this.Hide();
                this.Show();
                //--products.listProducts.Clear();
                //--products.FillListProducts();
                if(dgvDatos.RowCount !=0)
                dgvDatos.CurrentCell.Selected = false;                
                dgvDatos.DefaultCellStyle.ForeColor = Color.Black;                
            }
            else
            {
                
                int value = 0;
                if (int.TryParse(txtSearch.Text, out value))
                {                   
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
                    var result = from s in PersonaRecibe
                                 where s.ProductName == (wordParam)
                                 select s;
                    foreach (var student in result)
                        MessageBox.Show("Producto seleccionado: " + student.ProductName);
                        dgvDatos.DefaultCellStyle.BackColor = Color.White;
                        dgvDatos.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            return products.listProducts;
        }
        
        private void btnViewData_Click(object sender, EventArgs e)
        {            
            string value = txtSearch.Text.ToString();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = SearchProducts(value.ToLower());            

            foreach (DataGridViewRow Row in dgvDatos.Rows) 
            {                
                string Valor = Convert.ToString(Row.Cells["Code"].Value);
                string Valor2 = Convert.ToString(Row.Cells["ProductName"].Value);
                Row.Selected = false;
                if (Valor == this.txtSearch.Text || Valor2.ToUpper() == txtSearch.Text || Valor2.ToLower() == txtSearch.Text)
                {
                    Row.Selected = true;
                    dgvDatos.DefaultCellStyle.BackColor = Color.White;
                    dgvDatos.DefaultCellStyle.ForeColor = Color.White;                    
                }
            }            
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {

            foreach(var dato in PersonaRecibe)
            {
                Products p = new Products();

                dgvDatos.DataSource = p.listProducts;
                //--dgvDatos.Rows.Add(dato.Code, dato.ProductName, dato.Price, dato.Quantity);
                //dgvDatos.Rows.Add(1);
            }            

            dgvDatos.DataSource = SearchProducts(txtSearch.Text);
            // dgvDatos.DataSource = PersonaRecibe;

            //any selected row at the beginning
            if (dgvDatos.RowCount != 0)
            {
                dgvDatos.CurrentCell.Selected = false;
            }
            //dgvDatos.CurrentCell.Selected = false;

            this.Hide();
            this.Show();
            //dgvDatos.DataSource = ventas.valor;                       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
