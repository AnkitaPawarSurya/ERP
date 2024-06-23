using ERP.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessService.Interface
{
    public  interface IUserService
    {
        public List<UserViewDisplayModel> GetUser();

        bool UserRegister(UserRegisterationViewModelcs userRegisterationViewModelcs);

        UserViewDisplayModel CheckLogin(string username, string password, out bool IsSuccess);

        bool DeleteUser(int id);

        UserRegisterationViewModelcs GetUser(int id);

    }
}
