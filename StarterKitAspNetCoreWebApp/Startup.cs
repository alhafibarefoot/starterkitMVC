using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarterKitAspNetCoreWebApp.Presistance;
using Microsoft.EntityFrameworkCore;

namespace StarterKitAspNetCoreWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //Add StraterKit Services
            // var connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=StarterKitSQLDatabaseProjectEF;Trusted_Connection=True;";
            // services.AddDbContext<VegaDBContext>(options => options.UseSqlServer(connectionString));



            services.AddDbContext<StarterKitProjectDBContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("StandardKitDBConnectionStrings")));

            // services.AddDbContext<StarterKitProjectDBContext>(x =>
            // {
            //     x.UseSqlite(Configuration.GetConnectionString("StandardKitDBConnectionStrings"));
            // });
            services.AddAutoMapper(typeof(Startup));

            //if we have Large cycle json data
            //services.AddControllers().AddNewtonsoftJson(options =>
            //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
