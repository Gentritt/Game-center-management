namespace Game_center_management.BO
{
	public class Orders
	{
		public int OrderID { get; set; }
		public int BillId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }

		public virtual Product ProductID { get; set; }
		public virtual Bill BillID { get; set; }


	}
}