using System.Data.SqlClient;

namespace Game_center_maagement.BO.Interfaces
{
	public interface IConvertToObject<T> where T:class
	{

		T ToObject(SqlDataReader reader);


	}
}