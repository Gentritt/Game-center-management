using System;

namespace Game_center_management.BO
{
	public class Computer: BaseObject
	{
		public int ComputerID { get; set; }
		public bool IsActive { get; set; }
		public double PricePerHour { get; set; }
		public int PartID { get; set; }
		public virtual ComputerParts ComputerParts { get; set; }


	}
}