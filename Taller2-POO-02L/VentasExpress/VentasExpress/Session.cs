using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    public class Session
    {
        private string uname;
        private string pass;

        public string Uname { get => uname; set => uname = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
