using Repository.Models.DTO;

namespace Repository.Models {
	public class User {
		public int ID {
			get; set;
		}
		public string Username {
			get; set;
		}
		public string Email {
			get; set;
		}
		public string Password {
			get; set;
		}
		public DateTime DateOfBirth {
			get; set;
		}
		public string FullName {
			get; set;
		}

		public static implicit operator UserDTO(User user) {
			return new UserDTO {
				ID = user.ID,
				Username = user.Username,
				Email = user.Email,
				FullName = user.FullName
			};
		}
	}
}
