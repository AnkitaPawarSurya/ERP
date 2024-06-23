using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessEntity
{
public class UserRegisterationViewModelcs
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; } 

        public string LastName { get; set; } = null!;

        public string MobNo { get; set; } = null!;
        public string Password { get; set; } = null!;

        public string ConfirmPassword { get; set; } = null!;    

        public DateOnly Dob { get; set; }


    }
}
