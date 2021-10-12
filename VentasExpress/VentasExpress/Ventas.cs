using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //Regular Expression for validate entrance of sells in textBox, "number,number,number..."
        Regex regexCadenaVenta = new Regex(@"^[\d,\d]{3,}$");

        private void btnSell_Click(object sender, EventArgs e)
        {
            //If the input of textBox does not match with the patron of sell, show error...
            if (!regexCadenaVenta.IsMatch(txtSearch.Text) || string.IsNullOrEmpty(txtSearch.Text))
            {
                lblError.Text = "¡Error, Formato de cadena de venta erronea!";
                txtSearch.Clear();
            }
            else
            {
                lblError.Text = "";

                string values = txtSearch.Text.ToString();
                //we create a list that is saving the values
                List<string> list = new List<string>();
                list = values.Split(',').ToList();
                //1,2,3,5,8,9 [example]
                for (int i = 0; i < list.Count(); i++)
                {
                    //taking numbers in odd positions
                    if ((i + 1) % 2 != 0)
                    {
                        //taking only id's
                        string id = list[i];

                        //taking quantities
                        int quantity;

                        //If the patern of the sell goes wrong throw the try catch it means the patern id wrong so i show a message...if not continues
                        try //boque try con todas las operaciones
                        {
                            quantity = Convert.ToInt32(list[i + 1]);
                        }
                        catch (Exception ex) //bloque catch para captura de error
                        {
                            string error = ex.Message; //acción para manejar el error
                            MessageBox.Show("¡Error, no hay ningun parámetro para el código del producto en la posición " + (i+1));
                            break;
                        }


                        //searching
                        var selectedProduct = (products.listProducts.Where(att => att.Code == id).Select(att => att).FirstOrDefault());

                        if (Convert.ToInt32(id) == 0)
                        {
                            MessageBox.Show("Codigo: " + id + " no existe en el inventario!");
                        }
                        else
                        {
                            //For to iterating the identify the codes of the products
                            for (int k = 1; k <= 10; k++)
                            {
                                //If the code wrote in the textBox is into de rage of the productos continues...
                                if (Convert.ToInt32(id) == k)
                                {
                                    if (selectedProduct.Quantity != 0)
                                    {
                                        //If de quantity wrote in the textBox is superiority...
                                        if (quantity > selectedProduct.Quantity)
                                        {
                                            MessageBox.Show("La cantidad " + quantity + " del producto " + selectedProduct.ProductName + " es insuficiente, se vendeá lo que hay en existencia");
                                            quantity = selectedProduct.Quantity;
                                            selectedProduct.Quantity = 0;
                                            break;
                                        }
                                        else
                                        {
                                            //Succesful
                                            selectedProduct.Quantity -= quantity; //operating
                                            MessageBox.Show("Venta de " + selectedProduct.ProductName + " se realizo exitosamente");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        //If the stock of the producto is cero, we can't sell so i figure about it...
                                        MessageBox.Show("El stock del producto " + selectedProduct.ProductName + " agotado, las disculpas del caso!");
                                    }
                                }
                            }
                        }

                    }
                }
                txtSearch.Text = "";
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = products.listProducts;
            }
        }
    }
}
