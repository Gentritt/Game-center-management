using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management;

namespace Game_center_management.BO
{
	public class Employess : BaseObject
	{
		public int ID { get; set; }
		public int PersonalID { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Adress { get; set; }
		public double Salary { get; set; }
		public DateTime WorkTime { get; set; }

		public string Email { get; set; }
		public DateTime Birthday { get; set; }
		public int PhoneNumber { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }

		//public virtual Role role { get; set; }

		//Ne rast qe dojm me perdor si foreign key prej naj tabele tjeter.
		//public virtual role Role { get; set; }
	}
}
