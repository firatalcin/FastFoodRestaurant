
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.Business.Concrete;
using RestaurantProject.Business.Interfaces;
using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.EntityFramework;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.SignalRApi.Mapping;
using System.Reflection;

namespace RestaurantProject.SignalRApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
           

            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("mssql"));
            });

            builder.Services.AddAutoMapper(typeof(AboutMapping));

            builder.Services.AddScoped<IAboutService, AboutManager>();
            builder.Services.AddScoped<IAboutDal, EfAboutDal>();

            

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

           
            app.MapControllers();

            app.Run();
        }
    }
}
