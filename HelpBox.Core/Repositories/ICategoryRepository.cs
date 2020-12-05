using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        //Kategorileri urunlerle beraber getir
        Task<Category> GetWithProductsByIdAsync(int categoryId);






    }
}
