using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface IProductRepository: IRepository<Product>
    {
        //Urunleri kategorilerle beraber getir
        Task<Product> GetWithCategoryByIdAsync(int ProductId);
    }
}
