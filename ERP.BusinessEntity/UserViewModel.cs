using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessEntity
{
    public class UserViewDisplayModel
    {

        public int UserId { get; set; }

        public string Email { get; set; } 

        public string FirstName { get; set; } 

        public string LastName { get; set; } = null!;

        public string MobNo { get; set; } = null!;

        public int Age { get; set; }
               
        public string RoleName { get; set; }



    }
}
