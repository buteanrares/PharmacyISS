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
        Accepted,
        Refused,
        Pending,
    }

    class Order
    {
        public int ID { get; set; }
        public DateTime? ETA { get; set; }
        public List<Medicine> Medicines { get; set; }
        public WorkingUnit Destination { get; set; }
        public string Issuer { get; set; }
        public Priority Priority { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public string Dispatcher { get; set; }
        public Status Status { get; set; }
        public DateTime? ConfirmationDate { get; set; }

        public Order(int id, DateTime? eta, List<Medicine> medicines, WorkingUnit destination, string issuer, Priority priority, DateTime? dispatcheddate = null, string dispatcher=null, Status status = Status.Pending, DateTime? confirmationdate = null)
        {
            this.ID = id;
            this.ETA = eta;
            this.Medicines = medicines;
            this.Destination = destination;
            this.Issuer = issuer;
            this.Priority = priority;
            this.DispatchedDate = dispatcheddate;
            this.Dispatcher = dispatcher;
            this.Status = status;
            this.ConfirmationDate = confirmationdate;
        }
        
    }
}
