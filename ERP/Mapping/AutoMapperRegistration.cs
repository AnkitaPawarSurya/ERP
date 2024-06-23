using AutoMapper;
using ERP.BusinessEntity;
using ERP.DataEntity;

namespace ERP.Mapping
{
    public class AutoMapperRegistration : Profile
    {
        public AutoMapperRegistration() 
        {
            CreateMap<UserViewDisplayModel, User>().ReverseMap().
            ForMember(y => y.RoleName, op => op.MapFrom(p => p.Role.Name)).
            ForMember(y => y.Age, op => op.MapFrom(p => System.DateTime.Now.Year - p.Dob.Year))
            ;

            CreateMap<RoleViewModel,RoleMaster>().ReverseMap();

            CreateMap<UserRegisterationViewModelcs,User>().ReverseMap();
        }

    }
}
