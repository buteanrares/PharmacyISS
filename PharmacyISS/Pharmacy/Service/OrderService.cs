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

        public OrderService()
        {
            this.OrderRepository = new OrderRepository();
        }

        public async Task Create(int id, DateTime eta, List<Medicine> medicines, Units destination, string issuer, Priority priority)
        {
            await this.OrderRepository.InsertAsync(new Order(id, eta, medicines, destination, issuer, priority));
        }

        public async Task<Order> Read(int id)
        {
            return await this.OrderRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Order>> ReadAll()
        {
            return await OrderRepository.GetAllAsync();
        }

        public async Task Update(int id, DateTime eta, List<Medicine> medicines, Units destination, string issuer, Priority priority)
        {
            await this.OrderRepository.UpdateAsync(new Order(id, eta, medicines, destination, issuer, priority));
        }

        public async Task Delete(int id)
        {
            await this.OrderRepository.DeleteRowAsync(id);
        }
    }
}
