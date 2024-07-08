using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using PRS_Server.Data;

namespace PRS_Server;

public class Program {
    public static void Main(string[] args) {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<PRS_ServerContext>(options =>

            options.UseSqlServer(builder.Configuration.GetConnectionString("PRS_ServerContext") ?? throw new InvalidOperationException("Connection string 'PRS_ServerContext' not found.")));

        builder.Services.AddDbContext<PRS_ServerContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("PRS_ServerContext")
               ?? throw new InvalidOperationException("Connection string 'PRS_ServerContext' not found.")));

        builder.Services.AddControllers();
        builder.Services.AddCors();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
