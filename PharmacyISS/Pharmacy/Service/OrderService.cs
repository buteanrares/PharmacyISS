using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Repository;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class OrderService
    {
        private OrderRepository OrderRepository;
        private OrderMedicineRepository OrderMedicineRepository;

        public OrderService()
        {
            this.OrderRepository = new OrderRepository();
            this.OrderMedicineRepository = new OrderMedicineRepository();
        }

        public async Task Create(int id, DateTime? eta, Dictionary<Medicine,int> medicines, int destination, string issuer, int priority, DateTime? dispatcheddate = null, string dispatcher=null, int status = 4, DateTime? confirmationdate = null)
        {
            foreach (var pair in medicines) {
                await this.OrderMedicineRepository.InsertAsync(new OrderMedicine(new Random().Next(1, 2147483647),id,pair.Key.ID,pair.Value));
                    }
            await this.OrderRepository.InsertAsync(new Order(id, eta, destination, issuer, priority, dispatcheddate, dispatcher, status, confirmationdate));
        }

        public async Task<Order> Read(int id)
        {
            return await this.OrderRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Order>> ReadAll()
        {
            return await this.OrderRepository.GetAllAsync();
        }

        public async Task<OrderMedicine> ReadOrderMedicine(int id)
        {
            return await this.OrderMedicineRepository.GetAsync(id);
        }

        public async Task<IEnumerable<OrderMedicine>> ReadAllOrderMedicine()
        {
            return await this.OrderMedicineRepository.GetAllAsync();
        }

        public async Task Update(int id, DateTime eta, List<Medicine> medicines, int destination, string issuer, int priority, DateTime? dispatcheddate = null,string dispatcher=null, int status = 4, DateTime? confirmationdate = null)
        {
            await this.OrderRepository.UpdateAsync(new Order(id, eta, medicines, destination, issuer, priority,dispatcheddate,dispatcher, status,confirmationdate));
        }

        public async Task Update(int id, DateTime eta, int destination, string issuer, int priority, DateTime? dispatcheddate = null, string dispatcher = null, int status = 4, DateTime? confirmationdate = null)
        {
            await this.OrderRepository.UpdateAsync(new Order(id, eta, destination, issuer, priority, dispatcheddate, dispatcher, status, confirmationdate));
        }

        public async Task Delete(int id)
        {
            await this.OrderRepository.DeleteRowAsync(id);
        }
    }
}
