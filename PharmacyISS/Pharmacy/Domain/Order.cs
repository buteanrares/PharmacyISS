using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    enum Priority
    {
        Low=1,
        Medium=2,
        High=3
    }

    enum Status
    {
        Confirmed=1,
        Accepted=2,
        Refused=3,
        Pending=4,
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

        public Order(int id, DateTime? eta, List<Medicine> medicines, int destination, string issuer, int priority, DateTime? dispatcheddate = null, string dispatcher=null, int status = 4, DateTime? confirmationdate = null)
        {
            this.ID = id;
            this.ETA = eta;
            this.Medicines = medicines;
            this.Destination = (WorkingUnit)destination;
            this.Issuer = issuer;
            this.Priority = (Priority)priority;
            this.DispatchedDate = dispatcheddate;
            this.Dispatcher = dispatcher;
            this.Status = (Status)status;
            this.ConfirmationDate = confirmationdate;
        }

        public Order(int id, DateTime? eta, int destination, string issuer, int priority, DateTime? dispatcheddate = null, string dispatcher = null, int status = 4, DateTime? confirmationdate = null)
        {
            this.ID = id;
            this.ETA = eta;
            this.Medicines = new();
            this.Destination = (WorkingUnit)destination;
            this.Issuer = issuer;
            this.Priority = (Priority)priority;
            this.DispatchedDate = dispatcheddate;
            this.Dispatcher = dispatcher;
            this.Status = (Status)status;
            this.ConfirmationDate = confirmationdate;
        }

    }
}
