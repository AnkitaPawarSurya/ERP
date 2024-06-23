using ERP.Repository.Concrete;
using ERP.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository
{
    public static class RepositoryDependencyContainer
    {
        public static void Registration (IServiceCollection servicecollection)
        {
            servicecollection.AddScoped<IUserRepository,UserRepository>();
            servicecollection.AddScoped<IRoleMasterRepository,RoleMasterRepository>();
        }

    }
}
