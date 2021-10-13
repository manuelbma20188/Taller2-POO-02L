using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public  List<Users> listUsers = new List<Users>(); //list of my class Users   

        public string hashPass(string pass)
        {
            string hash;
            //string pass1 = "1";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(pass);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                // MessageBox.Show("The SHA256 hash "  + " is: " + hash);
            }
            return hash;
        }

        public void FillUsers()
        {            
            if (listUsers.Count == 0)
            {
                listUsers.Add(new Users { Code = 1, Username = "admin", Password = hashPass("admin123") }); //CAMBIAR CREDENCIALES
                listUsers.Add(new Users { Code = 2, Username = "vendedor", Password = hashPass("Vendedor123") });
                listUsers.Add(new Users { Code = 3, Username = "Invitado", Password = hashPass("invitadoinvitado123") });
            }
        }
        public bool setList(string uname, string pass)
        {
            string aux = hashPass(pass);
            bool ok = false; //we use this var to validate the credentials           
            
            for (var i = 0; i < listUsers.Count; i++) //accessing to the list
            {
                if (uname == listUsers[i].Username && (listUsers[i].Password) == aux)
                {
                    ok = true;     //if the users exist, return true               
                }
            }
            return ok;
        }
    }
}
