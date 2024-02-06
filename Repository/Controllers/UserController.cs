using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Models.DTO;
using Repository.Repositories;

namespace Repository.Controllers;

/// <summary>
/// Represents a controller for the user model.
/// </summary>
/// <param name="config">The configuration for the application.</param>
/// <param name="userRepo">The repository for the user model.</param>
[ApiController]
[Route("[controller]")]
public class UserController(IConfiguration config, IUserRepository userRepo) : ControllerBase {
	private readonly IConfiguration _config = config ?? throw new ArgumentNullException(nameof(config));
	private readonly IUserRepository _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));

	/// <summary>
	/// Retrieves all users.
	/// </summary>
	/// <returns>A list of user DTOs.</returns>
	/// <response code="200">Returns the list of all user DTOs</response>
	[HttpGet]
	[ProducesResponseType(typeof(List<UserDTO>), StatusCodes.Status200OK)]
	public IActionResult GetAll() {
		var users = _userRepo.FindAll();
		var userDTOs = users.Select(u => (UserDTO)u).ToList();

		return Ok(userDTOs);
	}

	/// <summary>
	/// Retrieves a user by their ID.
	/// </summary>
	/// <param name="id">The ID of the user to retrieve.</param>
	/// <returns>A user DTO if a user with the specified ID exists; otherwise, NotFound.</returns>
	/// <response code="200">Returns the user DTO</response>
	/// <response code="404">If no user is found with the specified ID</response>
	[HttpGet("{id:int}")]
	[ProducesResponseType(typeof(UserDTO), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public IActionResult GetByID(int id) {
		var user = _userRepo.FindByCondition(u => u.ID == id).FirstOrDefault();
		if (user == null) {
			return NotFound();
		}

		UserDTO userDTO = (UserDTO)user;

		return Ok(userDTO);
	}


	/// <summary>
	/// Create a new user.
	/// </summary>
	/// <param name="user">The user to create.</param>
	/// <returns>The created user along with a 201 Created response.</returns>
	/// <response code="201">Returns the newly created user</response>
	/// <response code="400">If the user data is invalid</response>
	[HttpPost]
	[ProducesResponseType(typeof(UserDTO), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public IActionResult Create(CreateUserDTO user) {
		var result = _userRepo.Create((User)user);

		var userDTO = (UserDTO)result;

		return Created("user", userDTO);
	}

	/// <summary>
	/// Updates an existing user.
	/// </summary>
	/// <param name="user">The user information to update.</param>
	/// <returns>A NoContent result indicating successful update, or NotFound if the user does not exist.</returns>
	/// <response code="204">Indicates the user was successfully updated</response>
	/// <response code="404">If no user is found with the specified ID</response>
	[HttpPut]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public IActionResult Update(User user) {
		var exists = _userRepo.FindByCondition(u => u.ID == user.ID).Any();
		if (!exists) {
			return NotFound();
		}

		_userRepo.Update(user);

		return NoContent();
	}

	/// <summary>
	/// Deletes a user by their ID.
	/// </summary>
	/// <param name="id">The ID of the user to delete.</param>
	/// <returns>NoContent if the user was successfully deleted, or NotFound if the user does not exist.</returns>
	/// <response code="204">Indicates the user was successfully deleted</response>
	/// <response code="404">If no user is found with the specified ID</response>
	[HttpDelete("{id:int}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public IActionResult Delete(int id) {
		var user = _userRepo.FindByCondition(u => u.ID == id).FirstOrDefault();
		if (user == null) {
			return NotFound();
		}

		_userRepo.Delete(user);
		return NoContent();
	}

}