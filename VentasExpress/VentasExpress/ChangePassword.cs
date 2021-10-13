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
        public Session sessions;
        public ChangePassword(Users user, Session session)
        {
            users = user;
            sessions = session;
            InitializeComponent();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string newPass = txtSearch.Text;
            
            var selectedUser = (users.listUsers.Where(att => att.Username == sessions.Uname).Select(att => att)).FirstOrDefault();            
            selectedUser.Password = users.hashPass(newPass);                     
            sessions = new Session();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
