using  ConceptArchitect.BookManagement;

using  BooksWeb02.Extensions;

namespace BooksWeb02
{ 
    public static class Startup
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            
            services.AddControllersWithViews();

            //services.AddAdoBMSRepository();

            services.AddEFBmsRepository();

            

            services.AddTransient<IAuthorService, PersistentAuthorService>();

            services.AddTransient<IBookService, PersistentBookService>();
            services.AddTransient<IUserService, PersistentUserService>();


            return services;
        }

        public static IApplicationBuilder ConfigureMiddlewares(this WebApplication app)
        {
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


            return app;
        }
            
    }
}
