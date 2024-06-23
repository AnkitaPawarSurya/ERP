using ERP.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessService.Interface
{
public interface IRoleMasterService
    {

        public List<RoleViewModel> GetRole();


    }
}
