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

    class Order
    {
        public int ID { get; set; }
        public DateTime ETA { get; set; }
        public List<Medicine> Medicines { get; set; }
        public Units Destination { get; set; }
        public Priority Priority { get; set; }

        public Order(int id, DateTime eta, List<Medicine> medicines,Units destination,Priority priority)
        {
            this.ID = id;
            this.ETA = eta;
            this.Medicines = medicines;
            this.Destination = destination;
            this.Priority = priority;
        }
    }
}
