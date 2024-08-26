using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NZWalksApi.Business.Services;
using NZWalksApi.Data;
using NZWalksApi.Data.Repositories;
using System.Text;

namespace NZWalksApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            InjectJWTAuthorisation(builder);
            InjectServices(builder);
            InjectAutoMapper(builder);
            InjectDatabase(builder);

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
                {
                    policy.WithOrigins("http://localhost:4200");
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                });
            });

            //Use this for JWT
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //Use this for JWT
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.MapControllers();

            app.Run();
        }

        private static void InjectJWTAuthorisation(WebApplicationBuilder builder)
        {
            var config = builder.Configuration;
            // Add JWT Bearer Authentication
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = config["JwtSettings: Issuer"],
                    ValidAudience = config["JwtSettings: Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(config["JwtSettings:Key"]!)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };
            });
        }

        private static void InjectAutoMapper(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        private static void InjectDatabase(WebApplicationBuilder builder)
        {
            //Do not add connectionstring here in production!! This is sensitive information!!
            string connectionString = builder.Configuration.GetConnectionString("NZConnectionString");
            builder.Services.AddDbContext<NZWalksDBContext>(options => options.UseSqlServer(connectionString));
        }

        private static void InjectServices(WebApplicationBuilder builder)
        {
            //Add dependencies here:
            builder.Services.AddScoped<IWalkRepository, WalkRepository>();
            builder.Services.AddScoped<IWalkService, WalkService>();
            builder.Services.AddScoped<IRegionRepository, RegionRepository>();
            builder.Services.AddScoped<IRegionService, RegionService>();
            builder.Services.AddScoped<IScoreCalculator, ScoreCalculator>();
            builder.Services.AddScoped<Business.Services.ILogger, Logger>();
        }
    }
}