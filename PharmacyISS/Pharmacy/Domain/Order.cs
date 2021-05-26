using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    enum Priority
    {
        Low,
        Medium,
        High
    }

    enum Status
    {
        Confirmed,
        Pending,
        Lost
    }

    class Order
    {
        public int ID { get; set; }
        public DateTime ETA { get; set; }
        public List<Medicine> Medicines { get; set; }
        public Units Destination { get; set; }
        public string Issuer { get; set; }
        public Priority Priority { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public Status Status { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public Order(int id, DateTime eta, List<Medicine> medicines, Units destination, string issuer, Priority priority)
        {
            this.ID = id;
            this.ETA = eta;
            this.Medicines = medicines;
            this.Destination = destination;
            this.Issuer = issuer;
            this.Priority = priority;
            this.DispatchedDate = null;
            this.Status = Status.Pending;
            this.ConfirmationDate = null;
        }
    }
}
