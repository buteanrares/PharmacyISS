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
    }
}
