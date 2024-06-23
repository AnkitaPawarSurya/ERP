using ERP.BusinessService;
using ERP.DataEntity;
using ERP.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace ERP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
            AddCookie(x => x.LoginPath = "/login/index");

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var configuration = builder.Configuration;

            var connectionString = configuration.GetConnectionString("ERPDB");


            builder.Services.AddDbContext<OfficeDetailsContext>(options => options.UseSqlServer(connectionString));

            RepositoryDependencyContainer.Registration(builder.Services);
            ServiceDependencyContainer.Registration(builder.Services);



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
