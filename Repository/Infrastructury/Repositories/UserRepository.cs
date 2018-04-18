using Domain.Entity;
using Domain.IContracts.IRepositories;
using Infrastructury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructury.Repositories
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
    }
}
