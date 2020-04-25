using System;

namespace Game_center_management.BO
{
	public class Computer: BaseObject
	{
		public int ComputerID { get; set; }
		public virtual Clients clientID { get; set; }
		//public virtual GuestID guesitID { get; set; }

		public bool IsActive { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }

		
	}
}