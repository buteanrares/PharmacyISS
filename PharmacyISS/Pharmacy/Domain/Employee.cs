using System;

namespace Pharmacy.Domain
{
    public enum WorkingUnit
    {
        Pharmacy,
        ICU,
        Pediatric,
        Neonatal,
        Oncology,
        Surgical,
        Rehabilitation
    }

    public abstract class Employee
    {
        protected internal int ID { get; set; }
        protected internal String Surname { get; set; }
        protected internal String Forename { get; set; }
        protected internal DateTime HireDate { get; set; }
        protected internal WorkingUnit WorkingUnit { get; set; }
    }
}
