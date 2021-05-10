using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Pharmacy.Domain;

namespace Pharmacy.Repository
{
    class DatabaseRepository
    {
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rares\Projects\Pharmacy\PharmacyISS\Pharmacy\PharmacyDB.mdf;Integrated Security=True";
        
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var query = @"SELECT
                            Email,
                            Username,
                            Password
                            FROM Account";
                connection.Open();
                accounts = connection.Query<Account>(query).ToList();
                connection.Close();
            }
            return accounts;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var query = @"SELECT
                            Name,
                            Title,
                            Salary,
                            HireDate
                            FROM Employee";
                connection.Open();
                employees = connection.Query<Employee>(query).ToList();
                connection.Close();
            }
            return employees;
        }

        public List<Medicine> GetMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();
            using(var connection = new SqlConnection(CONNECTION_STRING))
            {
                var query = @"SELECT
                            Name,
                            PackSize
                            FROM Medicine";
                connection.Open();
                medicines = connection.Query<Medicine>(query).ToList();
                connection.Close();
            }
            return medicines;
        }

        static async Task Create()
        {

        }

        static async Task Read()
        {

        }

        static async Task Update()
        {

        }

        static async Task Delete()
        {

        }
    }
}
