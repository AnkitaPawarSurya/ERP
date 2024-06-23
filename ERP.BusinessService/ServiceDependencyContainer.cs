using ERP.BusinessService.Concrete;
using ERP.BusinessService.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BusinessService
{
 public static class ServiceDependencyContainer
    {
        public static void Registration(IServiceCollection servicecollection)
        {
            servicecollection.AddScoped<IUserService, UserService>();
            servicecollection.AddScoped<IRoleMasterService,RoleMasterService>();
        }

    }
}
