using Repository.Contexts;
using Repository.Models;

namespace Repository.Repositories {
	public class UserRepository(MainContext context) : 
		RepositoryBase<User>(context), IUserRepository;
}
