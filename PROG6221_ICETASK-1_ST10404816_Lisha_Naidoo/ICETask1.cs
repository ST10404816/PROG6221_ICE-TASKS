using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICETASK_1_ST10404816_Lisha_Naidoo
{
	internal class ICETask1
	{
		//Prints first and last name on seperate lines with Capital letters
		public static void ToUpper(string n)
		{
			string[] names = n.Split(' ');
			Console.WriteLine("---Printing fullname on seperate lines in captial letters---");
			Console.WriteLine(names[0].ToUpper());
			Console.WriteLine(names[1].ToUpper());
			Console.WriteLine();

		}

		//Prints the date in 3 different formats
		public static void Date()
		{
			Console.WriteLine("---Printing date in 3 different formats---");
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
			Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
			Console.WriteLine(DateTime.Now.ToString("ddd, dd MM yyyy"));

		}
		
	}
}

/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */
