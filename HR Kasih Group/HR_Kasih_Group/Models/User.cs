using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kasih_Group.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Emp_ID { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            this.Emp_ID = username;
            this.Password = password;
        }
    }
}
