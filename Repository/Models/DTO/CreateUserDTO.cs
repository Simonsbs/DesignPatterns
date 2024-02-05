namespace Repository.Models.DTO;

public class CreateUserDTO {
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

	public static explicit operator User(CreateUserDTO user) {
		return new User {
			Username = user.Username,
			Email = user.Email,
			Password = user.Password,
			DateOfBirth = user.DateOfBirth,
			FullName = user.FullName
		};
	}
}