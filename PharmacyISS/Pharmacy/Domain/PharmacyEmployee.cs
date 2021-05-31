using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class PharmacyEmployee : Employee
    {
        public PharmacyEmployee(int id, string surname, string forename, DateTime hiredate) : base(id, surname, forename, hiredate, WorkingUnit.Pharmacy) { }

    }
}
