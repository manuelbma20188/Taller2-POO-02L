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
        Users users = new Users(); 
        Session session = new Session();
        public WelcomeView()
        {            
            InitializeComponent();            
        }
        Products products = new Products();
        
        private bool verifySession()
        {
            if(session.Uname != null)
            {
                return true;
            }
            return false;
        }

        private void log()
        {
            Inicio form1 = new Inicio(users);
            this.Hide();
            if (form1.ShowDialog() == DialogResult.OK)
            {                
                session = form1.session;
            }
            lblWelcome.Text = "Bienvenido " + session.Uname;
            this.Show();
        }

        private void WelcomeView_Load(object sender, EventArgs e)
        {
            users.FillUsers();
            if (!verifySession())
            {
                this.Hide();

                log();
                this.Show();
            }            
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
            ChangePassword changePassword = new ChangePassword(users, session);                        
            if(changePassword.ShowDialog() == DialogResult.OK)
            {
                users = changePassword.users;
                session = changePassword.sessions;
                if (!verifySession())
                {
                    log();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            Ventas salesInventory = new Ventas(products);             
            salesInventory.Show();
            products = salesInventory.products;                       
        }
    }
}
