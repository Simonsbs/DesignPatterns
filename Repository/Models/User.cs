using Repository.Models.DTO;
using System; // Required for DateTime

namespace Repository.Models;

/// <summary>
/// Represents a user entity in the database.
/// </summary>
public class User {
	/// <summary>
	/// Gets or sets the user's ID.
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// Gets or sets the username.
	/// </summary>
	public string Username { get; set; }

	/// <summary>
	/// Gets or sets the email address.
	/// </summary>
	public string Email { get; set; }

	/// <summary>
	/// Gets or sets the password. Note: Storing passwords in plain text is not secure.
	/// Consider using hashed passwords instead.
	/// </summary>
	public string Password { get; set; }

	/// <summary>
	/// Gets or sets the date of birth.
	/// </summary>
	public DateTime DateOfBirth { get; set; }

	/// <summary>
	/// Gets or sets the full name.
	/// </summary>
	public string FullName { get; set; }

	/// <summary>
	/// Provides an implicit conversion from a <see cref="User"/> to a <see cref="UserDTO"/>.
	/// This allows for easy conversion between the user entity and its DTO representation.
	/// </summary>
	/// <param name="user">The user instance to convert.</param>
	/// <returns>A new instance of <see cref="UserDTO"/> based on the provided user.</returns>
	public static implicit operator UserDTO(User user) {
		return new UserDTO {
			ID = user.ID,
			Username = user.Username,
			Email = user.Email,
			FullName = user.FullName
			// Ensure any other relevant fields are mapped as needed.
		};
	}
}