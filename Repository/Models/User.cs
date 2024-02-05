namespace Repository.Models {
	public class User {
		public int ID { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string FullName { get; set; }
	}
}
