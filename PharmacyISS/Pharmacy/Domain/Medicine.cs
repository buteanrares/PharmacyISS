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
        public int packSize { get; set; }

        public Medicine(int id, string name, int packsize)
        {
            this.ID = id;
            this.Name = name;
            this.packSize = packSize;
        }
    }
}
