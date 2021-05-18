using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Repository;
using Pharmacy.Domain;

namespace Pharmacy.Service
{
    class AccountService
    {
        private AccountRepository AccountRepository;

        public AccountService()
        {
            this.AccountRepository = new AccountRepository();
        }

        public async Task Create(int id, string username, string password, string email, Employee employee)
        {
            await this.AccountRepository.InsertAsync(new Account(id, username, password,email,employee));
        }

        public async Task<Account> Read(int id)
        {
            return await this.AccountRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Account>> ReadAll()
        {
            return await AccountRepository.GetAllAsync();
        }

        public async Task Update(int id, string username, string password, string email, Employee employee)
        {
            await this.AccountRepository.UpdateAsync(new Account(id, username, password, email, employee));
        }

        public async Task Delete(int id)
        {
            await this.AccountRepository.DeleteRowAsync(id);
        }
    }
}
