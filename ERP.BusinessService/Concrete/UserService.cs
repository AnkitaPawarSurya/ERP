using AutoMapper;
using ERP.BusinessEntity;
using ERP.BusinessService.Interface;
using ERP.Common;
using ERP.DataEntity;
using ERP.Repository.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessService.Concrete
{
    public class UserService : IUserService
    {
        private IUserRepository _userrepository;

        private readonly IMapper _mapper;
        public UserService(IUserRepository userrepository,IMapper mapper)
        {
            _userrepository = userrepository;
            _mapper = mapper;
        }

        public List<UserViewDisplayModel> GetUser()
        {
            var d =_userrepository.GetUser();
            return _mapper.Map<List<UserViewDisplayModel>>(d);
        }

        public bool UserRegister(UserRegisterationViewModelcs userRegisterationViewModelcs)
        {
            var m = _mapper.Map<User>(userRegisterationViewModelcs);
            var salt = Helper.GeneratePassword(5);

            m.PasswordSalt = salt;
            m.PasswordHash= Helper.EncodePassword(userRegisterationViewModelcs.Password, salt);
            m.RoleId = 1;

            return _userrepository.AddEditUser(m);
        }

		public UserViewDisplayModel CheckLogin(string username, string password, out bool IsSuccess)
		{
			var k =_userrepository.CheckLogin(username, password,out IsSuccess);
            return _mapper.Map<UserViewDisplayModel>(k);
		}

		public bool DeleteUser(int id)
		{
			return _userrepository.DeleteUser(id);
		}

        public UserRegisterationViewModelcs GetUser(int id)
        {
            var j= _userrepository.GetUser(id);
            return _mapper.Map<UserRegisterationViewModelcs>(j);
        }
    }
}
