using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LCandMikeProject.Data;
namespace LCandMikeProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LCmikeContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LCmikeContext") ?? throw new InvalidOperationException("Connection string 'LCmikeContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
