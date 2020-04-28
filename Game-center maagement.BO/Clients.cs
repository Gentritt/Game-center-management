using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_center_management.BO
{
	public class Clients: BaseObject
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public int PersonalID { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public int PhoneNumber { get; set; }
		public DateTime Birthday { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
		public double Balance { get; set; }

		public bool IsGuest { get; set; }




	}
}