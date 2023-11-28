
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace swetHome.Models
{
	[Table("Users",Schema ="SweetHome")]
	public class Users
	{
		[Key]
		public long UsersId { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public double PhoneNumber { get; set; }
		public string Adress { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string LastName { get; set; }



		
	}
}
