using Domain.Entity;
using Domain.IContracts.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IContracts.IBusiness
{
    public interface IUserBusiness
    {
        void Register(Users obj);
        void Delete(Users obj);
        void Update(Users obj);
        List<Users> List(Users obj);
        List<Users> ListAll();

    }
}
