using System;

namespace Game_center_management.BO
{
	public class Bill : BaseObject
	{
		public int BillID { get; set; }
        public string ClientUsername { get; set; }
        public string EmployeeUsername { get; set; }
        public int ComputerId { get; set; }
        public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public double Total { get; set; }
        public virtual Clients Client { get; set; }
		public virtual Computer ComputerID { get; set; }
		public virtual Employess Employee { get; set; }



	}
}