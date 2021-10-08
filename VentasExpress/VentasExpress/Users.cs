using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    public class Users
    {
        //atributes
        private int code;
        private string username;
        private string password;

        public int Code { get => code; set => code = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }        
    }
}
