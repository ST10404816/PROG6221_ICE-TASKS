using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICETASK_1_ST10404816_Lisha_Naidoo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ICETask1 ICETask1 = new ICETask1();

			//Asks the user to enter their full name
			Console.WriteLine("ICE Task 1\n");

			Console.Write("Please enter your fullname: ");
			string fullName = Console.ReadLine();
			ICETask1.ToUpper(fullName);
			ICETask1.Date();
			Console.ReadLine();

		}
	}
}

/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */
