using System;

namespace Game_center_management.BO
{
	public class Bill
	{
		public int BillID { get; set; }
		//public virtual Clients clientID { get; set; }
		//public virtual Computer computerID { get; set; }
		//public virtual Product ProductID { get; set; }
		public string ProductName { get; set; }
		public double ProductPrice { get; set; }
		public int Quantity { get; set; }

		//public DateTime StartTime { get; set; }
		//public DateTime EndTime { get; set; }
		public double Total { get; set; }





	}
}