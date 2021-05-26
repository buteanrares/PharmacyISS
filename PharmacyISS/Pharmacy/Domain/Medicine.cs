using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain
{
    class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PackSize { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Medicine(int id, string name, int packsize, int quantity, DateTime expirationdate)
        {
            this.ID = id;
            this.Name = name;
            this.PackSize = packsize;
            this.Quantity = quantity;
            this.ExpirationDate = expirationdate;
        }
    }
}
