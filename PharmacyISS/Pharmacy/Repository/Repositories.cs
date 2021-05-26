using Pharmacy.Domain;

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
        public OrderRepository() : base("Order") { }
    }
}
