using System;

namespace Game_center_management.BO
{
	public class Bill
	{
		public int BillID { get; set; }
		public string ProductName { get; set; }
		public double ProductPrice { get; set; }
		public int Quantity { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public double Total { get; set; }
		public virtual Clients ClientID { get; set; }
		public virtual Computer ComputerID { get; set; }
		public virtual Employess EmployeeID { get; set; }



	}
}