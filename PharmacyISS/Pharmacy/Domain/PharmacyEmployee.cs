using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class PharmacyEmployee : Employee
    {
        public string Unit { get; } = "Pharmacy";

        public PharmacyEmployee(int id, string surname, string forename, DateTime hiredate)
        {
            this.ID = id;
            this.Surname = surname;
            this.Forename = forename;
            this.HireDate = hiredate;
        }
    }
}
