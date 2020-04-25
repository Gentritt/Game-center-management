using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_center_management.BO.Interfaces
{
	public interface IbaseCrud<T>
	{
		//Interface gjenerik qe kthen bool,int,void	dhe ka metodat Insert,ADD,REmove,Modify...

		int ADD(T model);
		int Modify(T model);
		int Remove(int ID); //Nese qelesi eshte ID ose autoincrement
		int Remove(T model); //nese rasteisht qelesi primar eshte prej 2 ose me shume kolonav.
		T get(int ID); //Nese qelsi eshte ID apo autoincrement
		T get(T model); //Te mirret sipas modelit nese qelesi eshte prej 2 ose me shume kolonav.

		List<T> GetAll(); //per me i kthy te dhenat e tabeles.
	}
}
