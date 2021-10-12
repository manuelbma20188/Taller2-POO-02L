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
    public partial class ChangePassword : Form
    {
        public Users users;
        public ChangePassword(Users user)
        {
            users = user;
            InitializeComponent();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string newPass = txtSearch.Text;
            //string n = Form1.name;
            //MessageBox.Show("" + n);
            var selectedUser = (users.listUsers.Where(att => att.Username == Form1.name).Select(att => att).FirstOrDefault());
            MessageBox.Show("" + selectedUser);
            // selectedUser.Password = "hola";
            foreach (var npass in (users.listUsers.Where(att => att.Username == Form1.name)))
            {
                npass.Password = newPass;
            }
            Form1 form1 = new Form1();
            MessageBox.Show("Contraseña actualizada correctamente");
            //this.WindowState = FormWindowState.Minimized;
            this.Close();
            form1.Show();
        }
    }
}
