using ERP.Common;
using ERP.DataEntity;
using ERP.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.Concrete
{
    public class UserRepository : IUserRepository
    {

        private readonly OfficeDetailsContext _officedetailscontext;

        public UserRepository (OfficeDetailsContext officeDetailsContext)
            {
               _officedetailscontext=officeDetailsContext;
            }
        public bool AddEditUser(User user)
        {
           if(user.UserId >0)
            {
                var d = _officedetailscontext.Users.Find(user.UserId);
                d.FirstName= user.FirstName;
                d.LastName= user.LastName;
                d.Dob = user.Dob;
                d.Gender = user.Gender;
                d.IsSubscribe = user.IsSubscribe;

            }

           else
            {
                _officedetailscontext.Users.Add(user);
            }
            return _officedetailscontext.SaveChanges() > 0 ? true : false;

        }

		public User CheckLogin(string username, string password, out bool IsSuccess)
		{
			var a = _officedetailscontext.Users.FirstOrDefault(x=>x.Email==username);

            if(a!=null)
            {
                    var Phash = Helper.EncodePassword(password, a.PasswordSalt);

                    if(Phash == a.PasswordHash)
                    {
                        IsSuccess = true;
                        return a;
                    }
                    else
                    {
                        IsSuccess=false;
                    }
            }
            else
            {
                IsSuccess = false;
            }

            return null;

		}

		public bool DeleteUser(int id)
        {
            var p = _officedetailscontext.Users.Find(id);
            _officedetailscontext.Remove(p);
            return _officedetailscontext.SaveChanges()>0? true: false;

        }

        public User GetUser(int id)
        {
            var p = _officedetailscontext.Users.Find(id);
            return p;
        }

        public List<User> GetUser()
        {
            return _officedetailscontext.Users.Include(y=>y.Role).ToList();
        }
    }
}
