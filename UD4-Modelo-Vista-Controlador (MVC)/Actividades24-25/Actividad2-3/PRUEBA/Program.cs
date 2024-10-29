using Microsoft.EntityFrameworkCore;
using PRUEBA.Models.Context;

namespace PRUEBA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<PokemonContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionMontecastelo")));

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
                pattern: "{controller}/{action}");

            app.MapControllerRoute(
                name: "agregar",
                pattern: "{controller=Pokemon}/{codigo?}");

            app.MapControllerRoute(
                name: "verpokemon",
                pattern: "{controller=Pokemon}/{action=VerPokemon}/{id?}");

            app.MapControllerRoute(
                name: "info",
                pattern: "{controller=Pokemon}/{action=Info}/{id}");

            app.Run();
        }
    }
}
