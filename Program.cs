using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string i;
			Console.WriteLine("Please enter a positive integer");
			i = Console.ReadLine();
				try
				{
					int m = Int32.Parse(i);
				}
				catch (FormatException)
				{
					Console.WriteLine("Input is not a string of digits");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Number is too long");
				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Value is zero");
				}
				finally
				{
					Console.ReadLine();
				}
		}
			
	}
}