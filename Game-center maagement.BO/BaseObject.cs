using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_center_management.BO
{
	public class BaseObject
	{

		public string Insertby { get; set; }
		public DateTime InserDate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdateDate { get; set; }
		public int LastUpdate { get; set; }
		 
	}
}
