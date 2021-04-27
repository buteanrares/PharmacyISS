using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    abstract class Employee
    {
        protected int ID {get;set;}
        protected String Surname { get; set; }
        protected String Forename { get; set; }
        protected DateTime HireDate { get; set; }
    }
}
