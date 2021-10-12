using Microsoft.VisualBasic;
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
    public partial class WelcomeView : Form
    {
        public WelcomeView()
        {
            InitializeComponent();
        }
        Products products = new Products();
        Users users = new Users();
        private void WelcomeView_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bienvenido " + Form1.name;                
        }        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewInventory viewInventory = new ViewInventory(products);
            viewInventory.Show();                        
            products = viewInventory.products;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(users);
            changePassword.Show();
            users = changePassword.users;


            //string newPass = Interaction.InputBox("Ingrese la nueva contraseña: ");
            //foreach (var npass in Form1.listUsers.Where(w => w.Username == Form1.name))
            //{
            //    npass.Password = newPass;
            //}
            //MessageBox.Show("Contraseña actualizada correctamente");
            ////this.WindowState = FormWindowState.Minimized;
            //this.Hide();
            //form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            Ventas salesInventory = new Ventas(products);             
            salesInventory.Show();
            products = salesInventory.products;                       
        }
    }
}
