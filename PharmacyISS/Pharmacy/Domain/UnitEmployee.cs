using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{

    class UnitEmployee : Employee
    {
        public UnitEmployee(int id, string surname, string forename, DateTime hiredate, WorkingUnit workingunit) : base(id, surname, forename, hiredate, workingunit) { }
    }
}
