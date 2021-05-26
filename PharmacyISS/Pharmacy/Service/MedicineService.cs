using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Repository;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class MedicineService
    {
        private MedicineRepository MedicineRepository;

        public MedicineService()
        {
            this.MedicineRepository = new MedicineRepository();
        }

        public async Task Create(int id, string name, int packsize, int quantity, DateTime expirationdate)
        {
            await this.MedicineRepository.InsertAsync(new Medicine(id, name, packsize, quantity, expirationdate));
        }

        public async Task<Medicine> Read(int id)
        {
            return await this.MedicineRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Medicine>> ReadAll()
        {
            return await MedicineRepository.GetAllAsync();
        }

        public async Task Update(int id, string name, int packsize, int quantity, DateTime expirationdate)
        {
            await this.MedicineRepository.UpdateAsync(new Medicine(id, name, packsize, quantity, expirationdate));
        }

        public async Task Delete(int id)
        {
            await this.MedicineRepository.DeleteRowAsync(id);
        }
    }
}
