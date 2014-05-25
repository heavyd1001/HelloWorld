using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			SayHello();
			Console.ReadLine();
		}
		public static void SayHello()
		{
			Console.WriteLine("Hello World!");
		}
		private static void SayGoodbye()
		{
			Console.WriteLine("Goodbye Cruel World");
		}
	}
}
