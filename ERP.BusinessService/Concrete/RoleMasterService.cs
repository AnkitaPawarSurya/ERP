using AutoMapper;
using ERP.BusinessEntity;
using ERP.BusinessService.Interface;
using ERP.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessService.Concrete
{
    public class RoleMasterService : IRoleMasterService
    {
        private IRoleMasterRepository _roleMasterRepository;

        private readonly IMapper _mapper;
        public RoleMasterService(IRoleMasterRepository roleMasterRepository,IMapper mapper)
        {
            _roleMasterRepository = roleMasterRepository;
            _mapper = mapper;
        }

        public List<RoleViewModel> GetRole()
        {
            var r =_roleMasterRepository.GetRole();
            return _mapper.Map<List<RoleViewModel>>(r);
        }
    }
}
