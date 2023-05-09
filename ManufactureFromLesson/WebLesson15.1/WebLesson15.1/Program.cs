using WebLesson15._1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebLesson15._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();// поодержка контроллеров и представлений
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");


            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

            //`string connection = builder.Configuration.GetConnectionString("DefaultConnection"); // получаем connectionString

            //// добавляем контекст ApplicationContext в качестве сервиса в приложение
            //builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}