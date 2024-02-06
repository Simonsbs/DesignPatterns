using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;

namespace Repository.Contexts;

/// <summary>
/// The main database context for interacting with the database using Entity Framework Core.
/// </summary>
public class MainContext : DbContext {
	/// <summary>
	/// Initializes a new instance of the <see cref="MainContext"/> class.
	/// </summary>
	/// <param name="options">The options to be used by the DbContext.</param>
	public MainContext(DbContextOptions<MainContext> options) : base(options) {
	}

	/// <summary>
	/// Gets or sets the users in the database.
	/// </summary>
	public DbSet<User> Users { get; set; }

	/// <summary>
	/// Configures the model that EF Core uses to build the database schema.
	/// This method also seeds the database with initial data.
	/// </summary>
	/// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		base.OnModelCreating(modelBuilder);

		// Seed the database with initial user data.
		modelBuilder.Entity<User>().HasData(new User {
			ID = 1,
			Username = "Simon",
			Password = "1234",
			DateOfBirth = DateTime.Now.AddYears(-30), // Consider using a fixed date for consistency.
			Email = "simon@email.com",
			FullName = "Simon Stirling"
		});
	}
}