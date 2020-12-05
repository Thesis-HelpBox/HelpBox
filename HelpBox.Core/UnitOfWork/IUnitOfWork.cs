using HelpBox.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        ICategoryRepository Categories { get; }

        //hafızada tutulan değişiklikleri veritabanına kaydetmek için saveChange metodu çağırılacak
        Task CommitAsync();

        void Commit();


    }
}
