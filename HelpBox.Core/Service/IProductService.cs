using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Service
{
    //Veritabanıyla ilgili olmayan product nesnesiyle ilgili olan metotlar için oluşturdum.
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithProductByIdAsync(int ProductId);

    }
}
