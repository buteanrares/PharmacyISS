using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Repository;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class EmployeeService
    {
        private EmployeeRepository EmployeeRepository;

        public EmployeeService()
        {
            this.EmployeeRepository = new EmployeeRepository();
        }

        public async Task Create(int id, string surname, string forename, DateTime hiredate, Units workingunit)
        {
            await this.EmployeeRepository.InsertAsync(new UnitEmployee(id, surname, forename, hiredate, workingunit));
        }

        public async Task Create(int id, string surname, string forename, DateTime hiredate)
        {
            await this.EmployeeRepository.InsertAsync(new PharmacyEmployee(id, surname, forename, hiredate));
        }

        public async Task<Employee> Read(int id)
        {
            return await this.EmployeeRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Employee>> ReadAll()
        {
            return await EmployeeRepository.GetAllAsync();
        }

        public async Task Update(int id, string surname,string forename, DateTime hiredate, Units workingunit)
        {
            await this.EmployeeRepository.UpdateAsync(new UnitEmployee(id, surname, forename, hiredate,workingunit));
        }

        public async Task Update(int id, string surname, string forename, DateTime hiredate)
        {
            await this.EmployeeRepository.UpdateAsync(new PharmacyEmployee(id, surname, forename, hiredate));
        }

        public async Task Delete(int id)
        {
            await this.EmployeeRepository.DeleteRowAsync(id);
        }
    }
}
