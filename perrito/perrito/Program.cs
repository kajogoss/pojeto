using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perrito
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa p = new Pessoa();

			Console.WriteLine(p.ToString());

			p.Nome = "Thigas";

			Console.WriteLine(p);
			Console.ReadKey();

		}


	}
}