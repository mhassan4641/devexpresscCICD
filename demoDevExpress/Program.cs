using demoDevExpress.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace demoDevExpress
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddDevExpressBlazor();
            builder.Services.AddDevExpressServerSideBlazorReportViewer();
            // If you use Bootstrap 5, specify the Bootstrap version explicitly
            builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options => {
                options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
            });

            builder.WebHost.UseWebRoot("wwwroot");
            builder.WebHost.UseStaticWebAssets();

            builder.Services.AddSingleton<WeatherForecastService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}