using Repository.Models;

namespace Repository.Repositories;

/// <summary>
/// Defines the contract for a repository managing user entities.
/// Inherits basic CRUD operations from <see cref="IRepositoryBase{User}"/>.
/// Use this interface to implement user-specific data access policies and methods.
/// </summary>
public interface IUserRepository : IRepositoryBase<User> {
	// Here, we can add any additional methods specific to the user repository,
	// such as FindByEmailAddress(string email) or ValidateUserCredentials(string username, string password).
}