using  ConceptArchitect.BookManagement;
using ConceptArchitect.BookManagement.Repositories.EFRepository;
using  BooksWeb02.Extensions;
using Microsoft.AspNetCore.Builder;

namespace BooksWeb02
{ 
    public static class Startup
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            
            services.AddControllersWithViews();

            //services.AddAdoBMSRepository();

            services.AddSwaggerGen();

            services.AddEFBmsRepository();

            services.AddTransient<IAuthorService, PersistentAuthorService>();

            services.AddTransient<IBookService, PersistentBookService>();

            return services;
        }



        public static IApplicationBuilder ConfigureMiddlewares(this WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            return app;
        }
            
    }
}
