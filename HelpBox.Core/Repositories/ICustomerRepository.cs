using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        //Alıcıyı getir
        Task<Product> GetWithCustomerByIdAsync(int CustomerId);
    }
}
