

using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PlataformaWebApi.Shared.Repository;
using PlataformaWebApi.Usuarios.Application.Queries.Handlers;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using PlataformaWebApi.Usuarios.Infraestructure.Interfaces;
using PlataformaWebApi.Usuarios.Infraestructure.Mappers;
using PlataformaWebApi.Usuarios.Infraestructure.Repository.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlataformaWebApi", Version = "v1" });
            });
            //services.AddSingleton<Repository>();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                                  builder =>
                                  {
                                      //builder.WithOrigins("http://localhost", "http://10.216.25.30");
                                      builder.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
                                  });
            });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
                    ClockSkew = TimeSpan.Zero
                };
            });
                
            services.AddDbContext<PlataformaWebApiContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:dbPlataformaWebApi"]));

            services.AddMediatR(typeof(GetUsuarioByIDQueryHandler).Assembly);

            services.AddScoped(typeof(IUsuarioRepositoryCreate), typeof(UsuarioRepositoryCreateEF));
            services.AddScoped(typeof(IUsuarioRepositorySearchById), typeof(UsuarioRepositorySearchByIdEF));
            services.AddScoped(typeof(IUsuarioRepositorySearchAll), typeof(UsuarioRepositorySearchAllEF));
            services.AddScoped(typeof(IUsuarioRepositoryRemove), typeof(UsuarioRepositoryRemoveEF));
            services.AddScoped(typeof(IUsuarioRepositoryUpdate), typeof(UsuarioRepositoryUpdateEF));
            services.AddScoped(typeof(IUsuarioRepositoryModify), typeof(UsuarioRepositoryModifyEF));
            services.AddScoped(typeof(IUsuarioMapper<Usuario>), typeof(UsuarioAutoMapper<Usuario>));

            services.AddScoped(typeof(UsuarioCreator));
            services.AddScoped(typeof(UsuarioRemover));
            services.AddScoped(typeof(UsuarioSearcherByID));
            services.AddScoped(typeof(UsuariosSearcher));
            services.AddScoped(typeof(UsuarioUpdater));
            services.AddScoped(typeof(UsuarioModifier));

            services.AddControllersWithViews().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlataformaWebApi v1"));
                
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
        }
    }
}
