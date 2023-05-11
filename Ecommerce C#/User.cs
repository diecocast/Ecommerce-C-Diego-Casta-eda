using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_C_
{
    public class User
    {
        private int id;
        private string name;
        private string last_name;
        private string username;
        private string password;
        private string email;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}