using Repository.Models;
using System;

namespace Repository.Models.DTO;

/// <summary>
/// Represents a Data Transfer Object (DTO) for creating a new user. This DTO captures all the necessary
/// information received from the client to create a user entity in the system.
/// </summary>
public class CreateUserDTO {
	public string Username { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public DateTime DateOfBirth { get; set; }
	public string FullName { get; set; }

	/// <summary>
	/// Provides an explicit conversion from a <see cref="CreateUserDTO"/> to a <see cref="User"/>.
	/// This conversion allows for the direct transformation of the DTO into a user entity,
	/// facilitating the creation of new user records in the database.
	/// </summary>
	/// <param name="dto">The CreateUserDTO instance to convert.</param>
	/// <returns>A new User entity populated with the CreateUserDTO's data.</returns>
	public static explicit operator User(CreateUserDTO dto) {
		return new User {
			Username = dto.Username,
			Email = dto.Email,
			Password = dto.Password, // Consider hashing this password before storage
			DateOfBirth = dto.DateOfBirth,
			FullName = dto.FullName
		};
	}
}