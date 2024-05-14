
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NZWalksApi.Business.Services;
using NZWalksApi.Data;
using NZWalksApi.Data.Repositories;

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


            //Add dependencies here:
            builder.Services.AddSingleton<IWalkRepository, WalkRepository>();
            builder.Services.AddScoped<IWalkService, WalkService>();
            builder.Services.AddSingleton<IRegionRepository, RegionRepository>();
            builder.Services.AddScoped<IRegionService, RegionService>();
            //Automapper gets installed here
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Add dependency to database here:
            //Do not add connectionstring here in production!! This is sensitive information!!
            //TODO: replace: DESKTOP-JQ22R14 with own credential
            string connectionString = "Data Source=DESKTOP-JQ22R14;Initial Catalog=NZWAlksDB;Integrated Security=True;TrustServerCertificate=True;";
            builder.Services.AddDbContext<NZWalksDBContext>(
                options => options.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
