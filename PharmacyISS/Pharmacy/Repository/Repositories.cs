using Dapper;
using Pharmacy.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Repository
{
    class AccountRepository : GenericRepository<Account>
    {
        public AccountRepository() : base("Account") { }
    }

    class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository() : base("Employee") { }
    }

    class MedicineRepository : GenericRepository<Medicine>
    {
        public MedicineRepository() : base("Medicine") { }
    }

    class OrderRepository : GenericRepository<Order>
    {
        public OrderRepository() : base("\"Order\"") { }

        public new async Task<IEnumerable<Order>> GetAllAsync()
        {
            using (var connection = CreateConnection())
            {
                IEnumerable<OrderMedicine> orderMedicines = await connection.QueryAsync<OrderMedicine>($"SELECT * FROM OrderMedicine");
                IEnumerable<Order> orders = await connection.QueryAsync<Order>($"SELECT * FROM \"Order\"");
                IEnumerable<Medicine> medicines = await connection.QueryAsync<Medicine>($"SELECT * FROM Medicine");
                foreach(Order order in orders)
                {
                    foreach(OrderMedicine orderMedicine in orderMedicines)
                    {
                        if (orderMedicine.OrderID == order.ID)
                        {
                            order.Medicines.Add(medicines.ToList().Find(med => med.ID==orderMedicine.MedicineID));
                        }
                    }
                }
                return orders;
            }
        }
    }

    class OrderMedicineRepository : GenericRepository<OrderMedicine>
    {
        public OrderMedicineRepository() : base("OrderMedicine") { }
    }
}
