using INTEX.Data;
using INTEX.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.OnnxRuntime;

namespace INTEX
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
            services.AddRazorPages();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdmin", policy =>
                {
                    policy.RequireRole("Admin");
                });
            });

            services.AddScoped<ICrashRepository, EFCrashRepository>();

            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddDbContext<INTEXDbContext>(options =>
            {
                options.UseMySql(DbHelper.GetRDSConnectionString("Identity"));
            });

            services.AddDbContext<CrashDbContext>(options =>
            {
                options.UseMySql(DbHelper.GetRDSConnectionString());
            });

            services.AddSingleton<InferenceSession>(
                new InferenceSession("wwwroot/crash_id_model.onnx")
                );
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

                //Enable HSTS on site in production
                app.Use(async (context, next) =>
                {
                    context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000;");
                    await next();
                });
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //Enable CSP Header
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Content-Security-Policy", "default-src 'self' use.fontawesome.com cdn.jsdelivr.net app.termly.io unpkg.com cdnjs.cloudflare.com www.w3.org 7o1vcvfox2.execute-api.us-east-1.amazonaws.com maps.googleapis.com www.google.com ajax.aspnetcdn.com 'sha256-rwMOiOeVICH7/Cjy5SkreID3OOi5HTrit357k22hUDQ='; img-src * data:; style-src * 'self' data: 'unsafe-inline';");
                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
