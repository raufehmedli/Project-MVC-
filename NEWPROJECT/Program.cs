using Microsoft.EntityFrameworkCore;
using NEWPROJECT.DAL;

namespace NEWPROJECT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });  
            var app = builder.Build();


           

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
             
           app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.MapControllerRoute("contact","contact-us",new {Controller = "Home", Action = "Contact" });
            app.MapControllerRoute("about","about-us", new {Controller = "Home" , Action = "About"});

            app.Run();

        }
    }
}