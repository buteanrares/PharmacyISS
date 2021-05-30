using System;

namespace Pharmacy.Domain
{
    public enum WorkingUnit
    {
        Pharmacy=1,
        ICU=2,
        Pediatric=3,
        Neonatal=4,
        Oncology=5,
        Surgical=6,
        Rehabilitation=7
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
