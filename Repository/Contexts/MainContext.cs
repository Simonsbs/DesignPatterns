using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Contexts {
	public class MainContext : DbContext {
		public MainContext(DbContextOptions<MainContext> options)
			: base(options) {
		}

		public DbSet<User> Users {
			get; set;
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<User>().HasData(
				new User {
					ID = 1, 
					Username = "Simon", 
					Password = "1234", 
					DateOfBirth = DateTime.Now.AddYears(-30), 
					Email = "simon@email.com", 
					FullName = "Simon Stirling"
				}
			);
		}
	}
}
