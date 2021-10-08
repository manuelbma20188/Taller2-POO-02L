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

        private void WelcomeView_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bienvenido " + Form1.name;            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewInventory viewInventory = new ViewInventory();
            viewInventory.Show();
            this.Hide();
        }
    }
}
