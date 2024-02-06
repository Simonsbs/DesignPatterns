using Repository.Contexts;
using Repository.Models;

namespace Repository.Repositories;

/// <summary>
/// Implements the user-specific repository operations, extending the generic repository base class
/// for the <see cref="User"/> entity. This class provides an abstraction layer over the generic CRUD operations,
/// potentially including user-specific data access functionalities.
/// </summary>
public class UserRepository : RepositoryBase<User>, IUserRepository {
	/// <summary>
	/// Initializes a new instance of the <see cref="UserRepository"/> class.
	/// </summary>
	/// <param name="context">The database context to be used by the repository.</param>
	public UserRepository(MainContext context) : base(context) {
	}

}