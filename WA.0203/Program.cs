using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA._0203
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "0123456789";
			int len = 3;
			var helper = new StringHelper();
			string result = string.Empty;

			result = helper.Left(value, len); //'012'
			Console.WriteLine(result == "012");

			value = null;
			result = helper.Left(value, len); //''
			Console.WriteLine(result.Length == 0);

			value = "0123456789";
			len = -3;
			result = helper.Left(value, len); //''
			Console.WriteLine(result.Length == 0);

			value = "0123456789";
			len = 1000;
			result = helper.Left(value, len); //'0123456789'
			Console.WriteLine(result == value);
			Console.ReadKey();
		}
	}

	public class StringHelper
	{
		/// <summary>
		/// 取得字串左邊N個字
		/// 如果字串是null,傳回空字串,
		/// 如果 len 小於等於零,傳回空字串
		/// 如果字串長度比len小,傳回全部字串
		/// </summary>
		/// <param name="value"></param>
		/// <param name="len"></param>
		/// <returns></returns>
		public string Left(string value, int len)
		{
			//if()
			if (string.IsNullOrEmpty(value)) return string.Empty; //字串null 

			if (value.Length > len && len <= 0) return string.Empty; //字串<=0

			if (value.Length <= len) return value; //字串長度比len小			

			return value.Substring(0, len);
		}
	}
}
