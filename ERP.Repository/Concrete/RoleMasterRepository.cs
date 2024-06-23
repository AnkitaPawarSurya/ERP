using ERP.DataEntity;
using ERP.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.Concrete
{
    public class RoleMasterRepository : IRoleMasterRepository
    {

        private readonly OfficeDetailsContext _officeDetailsContext;


        public RoleMasterRepository(OfficeDetailsContext officeDetailsContext)
        {
            _officeDetailsContext = officeDetailsContext;
        }

        public List<RoleMaster> GetRole()
        {
            return _officeDetailsContext.RoleMasters.ToList();
        }
    }
}
