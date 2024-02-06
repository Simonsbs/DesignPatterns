
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;
using Repository.Repositories;

namespace Repository;
public class Program {
	public static void Main(string[] args) {
		var builder = WebApplication.CreateBuilder(args);

		// Add SQLite support to the application
		SQLitePCL.Batteries.Init();
		builder.Services.AddDbContext<MainContext>(o => {
			o.UseSqlite(builder.Configuration.GetConnectionString("MainDB"));
		});

		// Add services to the container.

		builder.Services.AddScoped<IUserRepository, UserRepository>();


		builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		// Add CORS support to the application
		builder.Services.AddCors((o) => {
			o.AddPolicy("open", b =>
				b.AllowAnyHeader()
					.AllowAnyOrigin()
					.AllowAnyMethod()
			);
		});

		var app = builder.Build();

#if DEBUG
		// This code makes sure the DB is up-to-date every time the API starts
		// This is not recommended for production
		using (var scope = app.Services.CreateScope()) {
			var context = scope.ServiceProvider.GetRequiredService<MainContext>();
			context.Database.Migrate();
		}
#endif

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment()) {
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();

		app.MapControllers();

		app.Run();
	}
}
