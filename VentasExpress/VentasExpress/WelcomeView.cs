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

        //Form1 form = new Form1();
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
            ViewInventory viewInventory = new ViewInventory();
            viewInventory.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newPass = Interaction.InputBox("Ingrese la nueva contraseña: ");
            foreach (var npass in Form1.listUsers.Where(w => w.Username == Form1.name))
            {
                npass.Password = newPass;
            }
            MessageBox.Show("Contraseña actualizada correctamente");
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            //form.Show();
        }
    }
}
