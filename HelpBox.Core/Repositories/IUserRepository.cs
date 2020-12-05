using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface IUserRepository:IRepository<Users>
    {
        //Kullanıcıları getir
        Task<Users> GetWithUserByIdAsync(int UserId);
    }
}
