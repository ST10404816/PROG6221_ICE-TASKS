using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICETASK_3_ST10404816_Lisha_Naidoo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ICE Task 3\n");
			Console.WriteLine("WATER MEASURING APPLICATION");
			Console.WriteLine("*****************************");

			string customerId;
			int monthlyUsage1, monthlyUsage2, monthlyUsage3;

			Console.Write("Enter the Customer ID >> ");
			customerId = Console.ReadLine();
			
			Console.Write("Enter the water measure for Month 1 of Customer " +customerId+ " >> ");
			monthlyUsage1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the water measure for Month 2 of Customer " + customerId + " >> ");
			monthlyUsage2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the water measure for Month 3 of Customer " + customerId + " >> ");
			monthlyUsage3 = Convert.ToInt32(Console.ReadLine());

			ICETask2 ICETask2 = new ICETask2(customerId, monthlyUsage1, monthlyUsage2, monthlyUsage3);

			Console.WriteLine("Total water usage: " +ICETask2.CalculateTotal());
			Console.WriteLine("Average water usage: " +ICETask2.CalculateAverage());

			Console.ReadLine();

		}
	}
}
/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */
