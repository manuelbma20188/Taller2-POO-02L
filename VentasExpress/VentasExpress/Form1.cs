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
        Users users = new Users();
        public static List<Users> listUsers = new List<Users>(); //list of my class Users                
        public static String name;
        WelcomeView form2 = new WelcomeView();

        //private string hashPass(string pass)
        //{
        //    string hash;
        //    //string pass1 = "1";
        //    using (SHA256 sha256Hash = SHA256.Create())
        //    {
        //        //From String to byte array
        //        byte[] sourceBytes = Encoding.UTF8.GetBytes(pass);
        //        byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
        //        hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

        //       // MessageBox.Show("The SHA256 hash "  + " is: " + hash);
        //    }
        //    return hash;
        //}

        // in this function, we're filling the prev list and checking if the user exists
        //private bool setList(string uname, string pass)
        //{
        //    string aux = users.hashPass(pass);
        //    bool ok=false; //we use this var to validate the credentials
        //    listUsers.Add(new Users { Code = 1, Username = "1", Password = users.hashPass("1")}); //CAMBIAR CREDENCIALES
        //    listUsers.Add(new Users { Code = 2, Username = "vendedor", Password = users.hashPass("vendedor123") });
        //    listUsers.Add(new Users { Code = 3, Username = "invitado", Password = users.hashPass("invitadoinvitado123") });

        //    for (var i = 0; i < listUsers.Count; i++) //accessing to the list
        //    {

        //        if(uname == listUsers[i].Username && (listUsers[i].Password) == aux)
        //        {
        //            ok = true;     //if the users exist, return true               

        //        }                                
        //    }
        //    return ok;
        //}
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit(); //closing form            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtUName.Focus();
            //txtUName.Text = hashPass("1");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we pass parameters to the function
            string uname = txtUName.Text;
            string pass = txtPass.Text;
            if(users.setList(uname, pass) == true)
            {
                MessageBox.Show("Credenciales correctas");
                name = txtUName.Text;
                //this.Hide();
                form2.Show();
               // form2.WindowState = FormWindowState.Maximized;

                txtUName.Text = "";
                txtPass.Text = "";
                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas!");
                txtPass.Text = "";
            }
        }
    }
}
