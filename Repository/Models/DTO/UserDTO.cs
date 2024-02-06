namespace Repository.Models.DTO;

/// <summary>
/// Represents a Data Transfer Object (DTO) for a user. This DTO is used to safely transfer user data
/// between the server and client, excluding sensitive information such as passwords.
/// </summary>
public class UserDTO {
	/// <summary>
	/// Gets or sets the user's identifier.
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// Gets or sets the username.
	/// </summary>
	public string Username { get; set; }

	/// <summary>
	/// Gets or sets the user's email address.
	/// </summary>
	public string Email { get; set; }

	/// <summary>
	/// Gets or sets the user's full name.
	/// </summary>
	public string FullName { get; set; }
}