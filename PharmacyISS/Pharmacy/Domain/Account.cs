using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    public class Account
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }

        public Account(int id, string username, string password, string email, Employee employee)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Employee = employee;
        }

        
    }
}
