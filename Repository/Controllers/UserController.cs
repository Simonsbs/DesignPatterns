using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Models.DTO;
using Repository.Repositories;

namespace Repository.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class UserController(IConfiguration config, IUserRepository userRepo) : ControllerBase {
		private readonly IConfiguration _config = config ?? throw new ArgumentNullException(nameof(config));
		private readonly IUserRepository _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));

		[HttpGet]
		public IActionResult GetAll() {
			var users = _userRepo.FindAll();
			var userDTOs = users.Select(u => (UserDTO)u).ToList();

			return Ok(userDTOs);
		}

		[HttpGet("{id:int}")]
		public IActionResult GetByID(int id) {
			var user = _userRepo.FindByCondition(u => u.ID == id).FirstOrDefault();
			if (user == null) {
				return NotFound();
			}

			UserDTO userDTO = (UserDTO)user;

			return Ok(userDTO);
		}

		[HttpPost]
		public IActionResult Create(CreateUserDTO user) {
			var result = _userRepo.Create((User)user);

			var userDTO = (UserDTO)result;

			return Created("user", userDTO);
		}

		[HttpPut]
		public IActionResult Update(User user) {
			var exists = _userRepo.FindByCondition(u => u.ID == user.ID).Any();
			if (!exists) {
				return NotFound();
			}

			_userRepo.Update(user);

			return NoContent();
		}

		[HttpDelete("{id:int}")]
		public IActionResult Delete(int id) {
			var user = _userRepo.FindByCondition(u => u.ID == id).FirstOrDefault();
			if (user == null) {
				return NotFound();
			}

			_userRepo.Delete(user);
			return NoContent();
		}
	}
}
