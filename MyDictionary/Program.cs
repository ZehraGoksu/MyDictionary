using System;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> customerNo = new Dictionary<int, string>();
			customerNo.Add(1, "Tuncay");
			customerNo.Add(2, "Olgun");
			customerNo.Add(3, "Taner");
			Console.WriteLine(customerNo.Length);

		}
	}
}
