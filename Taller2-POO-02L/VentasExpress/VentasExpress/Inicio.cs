using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasExpress
{
    public partial class Inicio : Form
    {
        Users users;
        public Session session = new Session();

        public Inicio(Users user = null)
        {            
            users = user;            
            InitializeComponent();
        }
        
        public static List<Users> listUsers = new List<Users>(); //list of my class Users                
        public static String name;
        private void btnSalir_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we pass parameters to the function
            string uname = txtUName.Text;
            string pass = txtPass.Text;
            if(users.setList(uname, pass) == true)
            {
                session.Uname = uname;
                session.Pass = pass;
                MessageBox.Show("Credenciales correctas");
                this.DialogResult = DialogResult.OK;
                this.Close();                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas!");
                txtPass.Text = "";
            }
        }
    }
}
