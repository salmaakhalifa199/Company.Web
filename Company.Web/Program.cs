using Company.Data.Contexts;
using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Services.Interfaces;
using Company.Services.Services;
using Microsoft.EntityFrameworkCore;

namespace Company.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //IConfiguration // 34an a3rf a'ra haga mn appsetting(json file)
           var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<CompanyDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // services lifetime
            #region AddTransient
            //builder.Services.AddTransient<IDepartmentRepository , DepartmentRepository>();
            // m3nha ani fi instance gaded bt3ml kol mara a request object  intance hytb3tli
            // astghdmo lw bt3ml m3 statless
            #endregion

            #region AddScoped
            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            // lama b3ml request btb3t instance mokhtlfa (per request )
            // astghdmo lw 3andy single request w shaghhla 3la obj wahed bs 
            #endregion

            #region AddSingleton
            //builder.Services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
            // instance wahed bs h-create 3la el application nafso 
            // monsab lw bshtgham haga zy global state  , shared resource(login , cashing , ...)
            #endregion

            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
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
