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

            //Add the head of the facture
            listBoxFactura.Items.Add("  Producto \tCant\t\tPrecio");
            listBoxFactura.ForeColor = Color.White;

            //the size where the facture is can not be show until i buy
            Size = new Size(530, 540);
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

        //Regular Expression for validate entrance of sells of the sucesion FOR THE PRESENT (5 candies) in textBox, "2,1,9,1 or 9,1,2,1"
        Regex regexSucesionRegalo = new Regex(@"(([2]{1}[,][1]){1}|([9]{1}[,][1]){1})|(([9]{1}[,][1]){1}|([2]{1}[,][1]){1})");


        //Public variables because we use it in different instances
        public string id;
        public int quantity;
        public string values;
        public double total;
        public double totalCon;
        public double totalSin;
        public double desc;
        public string dulce;


        private void btnSell_Click(object sender, EventArgs e)
        {
            //Give color to see the items and inicializating the variables 
            listBoxFactura.ForeColor = Color.Black;

            //If the input of textBox does not match with the patron of sell, show error...
            if (!regexCadenaVenta.IsMatch(txtSearch.Text) || string.IsNullOrEmpty(txtSearch.Text))
            {
                lblError.Text = "¡Error, Formato de cadena de venta erronea!";
                txtSearch.Clear();
            }
            else
            {
                lblError.Text = "";

                values = txtSearch.Text.ToString();
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
                        id = list[i];

                        //If the patern of the sell goes wrong throw the try catch it means the patern id wrong so i show a message...if not continues
                        try //boque try con todas las operaciones
                        {
                            //taking quantities
                            quantity = Convert.ToInt32(list[i + 1]);
                        }
                        catch (Exception ex) //bloque catch para captura de error
                        {
                            string error = ex.Message; //acción para manejar el error
                            MessageBox.Show("¡Error, no hay ningun parámetro para el código del producto en la posición " + (i + 1));
                            break;
                        }

                        //searching
                        var selectedProduct = (products.listProducts.Where(att => att.Code == id).Select(att => att).FirstOrDefault());

                        if (Convert.ToInt32(id) < 1 && Convert.ToInt32(id) > 10)
                        {
                            MessageBox.Show("Codigo: " + id + " no existe en el inventario!");
                        }
                        else
                        {
                            //this function void add the head of the facture
                            fillHead();

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

                                            selectedProduct.Quantity -= quantity;

                                            //operating
                                            //Add the productos solds in the facture
                                            listBoxFactura.Items.Add(selectedProduct.ProductName + "\t\t" + quantity + "\t" + " x " + "\t$" + selectedProduct.Price);

                                            //calculate the total
                                            total += (quantity * selectedProduct.Price);

                                            //In case the total is greater than 20 i give descount...if not, no...
                                            if (total > 20)
                                            {
                                                desc = (total * 0.03);
                                                totalCon = (total - desc);
                                            }
                                            else
                                            {
                                                totalSin = total;
                                            }

                                            //With the expression i validate the patron to give a present or not
                                            if (regexSucesionRegalo.IsMatch(txtSearch.Text))
                                            {
                                                dulce = "Regalo de 5 dulces a $0.00";
                                            }
                                            else
                                            {
                                                dulce = "";
                                            }

                                            //Resize the form to see the facture
                                            Size = new Size(835, 540);
                                        }
                                        else
                                        {
                                            //Succesful
                                            selectedProduct.Quantity -= quantity;

                                            //operating
                                            //Add the productos solds in the facture
                                            listBoxFactura.Items.Add(selectedProduct.ProductName + "\t\t" + quantity + "\t" + " x " + "\t$" + selectedProduct.Price);

                                            //calculate the total
                                            total += (quantity * selectedProduct.Price);

                                            //In case the total is greater than 20 i give descount...if not, no...
                                            if (total > 20)
                                            {
                                                desc = (total * 0.03);
                                                totalCon = (total - desc);
                                            }
                                            else
                                            {
                                                totalSin = total;
                                            }

                                            //With the expression i validate the patron to give a present or not
                                            if (regexSucesionRegalo.IsMatch(txtSearch.Text))
                                            {
                                                dulce = "Regalo de 5 dulces a $0.00";
                                            }
                                            else
                                            {
                                                dulce = "";
                                            }

                                            //Resize the form to see the facture
                                            Size = new Size(835, 540);
                                        }
                                    }
                                    else
                                    {
                                        //If the stock of the producto is cero, we can't sell so i figure about it...
                                        MessageBox.Show("El stock del producto " + selectedProduct.ProductName + " agotado, las disculpas del caso!");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = products.listProducts;

                //Add the present to the facture if exits
                if (regexSucesionRegalo.IsMatch(txtSearch.Text))
                {
                    dulce = "Regalo de 5 dulces a $0.00";
                    listBoxFactura.Items.Add(dulce);
                }
                else
                {
                    dulce = "";
                    listBoxFactura.Items.Add(dulce);
                }
                txtSearch.Text = "";
                //In case the total is greater than 20 i give descount...if not, no...and show the total and/or descount
                if (total > 20)
                {

                    listBoxFactura.Items.Add("  Total" + "\t\t\t\t$" + Math.Round(totalCon, 2));
                    listBoxFactura.Items.Add("  Descuento" + "\t\t\t$" + desc);
                    listBoxFactura.Items.Add("           " + "\t\t\t");

                }
                else
                {
                    listBoxFactura.Items.Add("  Total" + "\t\t\t\t$" + Math.Round(totalSin, 2));
                    listBoxFactura.Items.Add("           " + "\t\t\t");
                }
            }
        }

        //void contains the head of the facture and i add it to show
        private void fillHead()
        {
            string head;

            head = "=================================";
            head += "\t\t    Ventas Don Diego";
            head += "\t\t\t\tCalle 5 Av. Norte No. 2";
            head += "\t\t\t Colonia Flor Blanca";
            head += "\t\t\t\t    S.S., El Salvador";
            head += "\t\t\t        Teléfono: 2510-3467";
            head += "\tFecha" + DateTime.Now;
            head += "\t=================================";
            head += "\t\t        Esta Venta\t\t";
            txtFactura.Text = head;
        }
    }
}