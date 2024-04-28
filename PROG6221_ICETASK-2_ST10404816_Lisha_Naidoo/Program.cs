using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICETASK_2_ST10404816_Lisha_Naidoo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ICE Task 2

			Console.WriteLine("ICE Task 2\n");
			Console.WriteLine("---Calculator App---\n");

			string input = " ";
			while (input != "0")
			{
				Console.Write("Enter two numbers and an operator: ");
				input = Console.ReadLine();
				ICETask2.calculate(input);
				Console.WriteLine();
			}

		}

	}
}

/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */