using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories;

namespace Repository.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class UserController(IConfiguration config, IUserRepository userRepo) : ControllerBase {
		private readonly IConfiguration _config = config ?? throw new ArgumentNullException(nameof(config));
		private readonly IUserRepository _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
		
		[HttpGet]
		public IActionResult GetAll() {
			var result = _userRepo.FindAll().ToList();
			return Ok(result);
		}

		[HttpGet("{id:int}")]
		public IActionResult GetByID(int id) {
			var result = _userRepo.FindByCondition(u => u.ID == id).FirstOrDefault();
			return Ok(result);
		}

		[HttpPost]
		public IActionResult Create(User user) {
			if (user == null) {
				return BadRequest();
			}

			var result = _userRepo.Create(user);

			return Created("user", result);
		}

		[HttpPut]
		public IActionResult Update(User user) {
			if (user == null) {
				return BadRequest();
			}

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
