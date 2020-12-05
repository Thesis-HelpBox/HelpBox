using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface ISenderRepository: IRepository<Sender>
    {
        //göndericileri getir
        Task<Sender> GetWithSenderByIdAsync(int SenderId);
    }
}
