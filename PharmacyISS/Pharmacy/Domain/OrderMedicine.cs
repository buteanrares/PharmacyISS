using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class OrderMedicine
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int MedicineID { get; set; }
        public int Quantity { get; set; }

        public OrderMedicine(int id, int orderid, int medicineid, int quantity)
        {
            this.ID = id;
            this.OrderID = orderid;
            this.MedicineID = medicineid;
            this.Quantity = quantity;
        }
    }
}
