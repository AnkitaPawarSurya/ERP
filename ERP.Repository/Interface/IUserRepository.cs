using ERP.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.Interface
{
    public interface IUserRepository
    {
        bool AddEditUser(User user);

        bool DeleteUser(int id);

        List<User> GetUser();

        User GetUser(int id);

        User CheckLogin(string username, string password, out bool IsSuccess);
    }
}
