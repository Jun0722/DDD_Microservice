using System;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Insfrastructure.Data.Repository
{
    /// <summary>
    /// Customer仓储，操作对象还是领域对象
    /// </summary>
    public class CustomerRepository:Repository<Customer>, ICustomerRepository
    {
        public Customer GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
