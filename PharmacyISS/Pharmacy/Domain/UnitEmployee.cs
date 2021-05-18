using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    enum Units{
        ICU,
        Pediatric,
        Neonatal,
        Oncology,
        Surgical,
        Rehabilitation
    }
    class UnitEmployee : Employee
    {
        private Units WorkingUnit { get; set; }

        public UnitEmployee(int id, string surname, string forename, DateTime hiredate, Units workingunit)
        {
            this.ID = id;
            this.Surname = surname;
            this.Forename = forename;
            this.HireDate = hiredate;
            this.WorkingUnit = workingunit;
        }
    }
}
