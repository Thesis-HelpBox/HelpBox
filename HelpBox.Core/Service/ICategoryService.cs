using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Service
{
    //Veritabanıyla ilgili olmayan category nesnesiyle ilgili olan metotlar için oluşturdum.
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);

    }
}
