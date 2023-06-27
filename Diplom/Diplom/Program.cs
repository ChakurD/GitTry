using Diplom.DataAccess;
using Diplom.DataAccess.DbPatterns;
using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.Services.Interfaces;
using Diplom.Services.Service;
using Microsoft.EntityFrameworkCore;

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

            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IUserServices, UserService>();
            builder.Services.AddTransient<ICategoryServices, CategoryService>();
            builder.Services.AddTransient<IItemServices, ItemService>();
            builder.Services.AddTransient<IStorageServices, StorageService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}