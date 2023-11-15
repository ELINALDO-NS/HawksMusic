using HawksMusic.API.Data;
using HawksMusic.API.Repositorios;
using HawksMusic.API.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace HawksMusic.API
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
           builder.Services.AddEntityFrameworkSqlite().
                AddDbContext<HawksDataContext>(
                options => options.UseSqlite(builder.Configuration.GetConnectionString("SQLite"))
                );
            
            builder.Services.AddScoped<IUsuarioRepositorio,UsuarioRepositorio>();
            builder.Services.AddScoped<IMusicaRepositorio,MusicaRepositorio>();
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