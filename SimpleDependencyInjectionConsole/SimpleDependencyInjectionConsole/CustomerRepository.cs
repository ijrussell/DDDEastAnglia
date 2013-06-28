using System.Collections.Generic;
using System.Linq;

namespace SimpleDependencyInjectionConsole
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connection;

        public CustomerRepository(string connection)
        {
            _connection = connection;
        }

        public Customer GetCustomer(string id)
        {
            return Db.Customers().FirstOrDefault(x => x.CustomerId == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return Db.Customers();
        }
    }
}