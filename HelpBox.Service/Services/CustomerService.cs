using HelpBox.Core.Models;
using HelpBox.Core.Repositories;
using HelpBox.Core.Service;
using HelpBox.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Service.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        public CustomerService(IUnitOfWork unitOfWork, IRepository<Customer> repository) : base(unitOfWork, repository)
        {
        }

        //public async Task<Customer> GetWithProductsByIdAsync(int customerId)
        //{
        //    return await _unitOfWork.Customers.GetWithProductsByIdAsync(customerId);
        //}
    }
}
