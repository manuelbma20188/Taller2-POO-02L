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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Users> listUsers = new List<Users>(); //list of my class Users                
        public static String name;
        WelcomeView welcomeView = new WelcomeView();
        //private void hashPass()
        //{
        //    string source = "Hello!";
        //    using (SHA256 sha256Hash = SHA256.Create())
        //    {
        //        //From String to byte array
        //        byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
        //        byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
        //        string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

        //        MessageBox.Show("The SHA256 hash of " + source + " is: " + hash);
        //    }
        //}

        // in this function, we're filling the prev list and checking if the user exists
        private bool setList(string uname, string pass)
        {
            bool ok=false; //we use this var to validate the credentials
            listUsers.Add(new Users { Code = 1, Username = "1", Password = "1"});
            listUsers.Add(new Users { Code = 2, Username = "vendedor", Password = "vendedor123" });
            listUsers.Add(new Users { Code = 3, Username = "invitado", Password = "invitadoinvitado123" });

            for (var i = 0; i < listUsers.Count; i++) //accessing to the list
            {
                if(uname == listUsers[i].Username && pass == listUsers[i].Password)
                {
                    ok = true;     //if the users exist, return true               
                }                                
            }
            return ok;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //closing form            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we pass parameters to the function
            string uname = txtUName.Text;
            string pass = txtPass.Text;
            if(setList(uname, pass) == true)
            {
                MessageBox.Show("Credenciales correctas");
                name = txtUName.Text;                
                welcomeView.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas!");
                txtPass.Text = "";
            }
        }
    }
}
