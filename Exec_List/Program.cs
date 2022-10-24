using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	/// <summary>
	/// Exec_List
	/// 宣告一個 List<Product> 變數, 存放多筆購買商品
	/// </summary>
	/// 
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> shopping = new List<Product>()
			{
				new Product{Id=1, thing="香蕉", price=30, amount=2},
				new Product{Id=2, thing="蘋果", price=50, amount=7},
			};
		}
	}

	class Product
	{
		public int Id { get; set; }
		public string thing { get; set; }
		public decimal price { get; set; }
		public int amount { get; set; }
	}
}
