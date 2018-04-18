using Domain.IContracts.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.IContracts.IRepositories;
using infrastructury.Repositories;

namespace Business.Business
{
    public class UserBusiness : IUserBusiness
    {
        IUserRepository _userrepository;
        public UserBusiness()
        {
            _userrepository = new UserRepository();
        }
        public void Delete(Users obj)
        {
            _userrepository.Deletar(d => d.Id == obj.Id);
            _userrepository.Commit();
        }

        public List<Users> List(Users obj)
        {
            return _userrepository.Get(g => g.Id == obj.Id).ToList();
        }

        public List<Users> ListAll()
        {
            return _userrepository.GetTodos().ToList();
        }

        public void Register(Users obj)
        {
            _userrepository.Adicionar(obj);
            _userrepository.Commit();
        }

        public void Update(Users obj)
        {
            _userrepository.Atualizar(obj);
            _userrepository.Commit();
        }
    }
}
