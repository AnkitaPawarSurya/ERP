using ERP.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.Interface
{
   public interface IRoleMasterRepository
    {

        public List<RoleMaster> GetRole();

    }
}
