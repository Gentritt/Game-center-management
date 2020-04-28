using System;

namespace Game_center_management.BO
{
	public class Product: BaseObject
	{

		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }
		//public DateTime ProductDate { get; set; }


	}
}