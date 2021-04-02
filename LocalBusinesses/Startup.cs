using System;  
using System.Collections.Generic;  
using System.Linq;
using System.Threading.Tasks;
using System.Text;  
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;  
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;  
using LocalBusinesses.Authentication;

namespace LocalBusinesses
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

      services.AddDbContext<ApplicationDbContext>(opt =>
          opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      
      services.AddControllers();
      
      services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();
      
      services.Configure<IdentityOptions>(options =>
      {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 0;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredUniqueChars = 0;
      });

      services.AddAuthentication(options =>  
      {  
          options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;  
          options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;  
          options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;  
      })
      .AddJwtBearer(options =>  
      {  
          options.SaveToken = true;  
          options.RequireHttpsMetadata = false;
          System.Console.WriteLine("~~~~~~Reached line 66");
          options.TokenValidationParameters = new TokenValidationParameters()  
          {  
              ValidateIssuer = true,  
              ValidateAudience = true,  
              ValidAudience = Configuration["JWT:ValidAudience"],  
              ValidIssuer = Configuration["JWT:ValidIssuer"],
              IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))  
          };  
          System.Console.WriteLine("~~~~~~Reached line 74");
      });  

      services.AddSwaggerGen(swagger =>
      {
        swagger.SwaggerDoc("v1", new OpenApiInfo
        {
          Version = "v1",
          Title = "LocalBusinesses API",
          Description = "ASP.NET Core Web API that holds information on local businesses in the area",
          Contact = new OpenApiContact
          {
            Name = "Woo Jin Kim",
            Email = "kimwoojin211@gmail.com",
            Url = new Uri("https://github.com/kimwoojin211"),
          },
          License = new OpenApiLicense
          {
            Name = "Use under MIT",
            Url = new Uri("https://https://opensource.org/licenses/MIT"),
          }
        });
        swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()  
        {  
          Name = "Authorization",  
          Type = SecuritySchemeType.ApiKey,  
          Scheme = "Bearer",  
          BearerFormat = "JWT",  
          In = ParameterLocation.Header,  
          Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",  
        });  
        swagger.AddSecurityRequirement(new OpenApiSecurityRequirement  
        {  
          {  
          new OpenApiSecurityScheme  
            {  
              Reference = new OpenApiReference  
              {  
                Type = ReferenceType.SecurityScheme,  
                Id = "Bearer"  
              }  
            },  
            new string[] {} 
          }
        });
      });
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
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }
      app.UseSwagger();
      app.UseSwaggerUI(swagger =>
      {
          swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
      });

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
