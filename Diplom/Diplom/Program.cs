using Diplom.DataAccess;
using Diplom.DataAccess.DbPatterns;
using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.DataAccess.Entity;
using Diplom.Services.Interfaces;
using Diplom.Services.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Diplom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Home/Login");
                });

            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IUserServices, UserService>();
            builder.Services.AddTransient<ICategoryServices, CategoryService>();
            builder.Services.AddTransient<IItemServices, ItemService>();
            builder.Services.AddTransient<IStorageServices, StorageService>();
            builder.Services.AddCors();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=MainPage}/{id?}");

            app.Run();

        }
    }
}
