using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICETASK_3_ST10404816_Lisha_Naidoo
{
	internal class ICETask2
	{
		//Variables
		private string customerId;
		private int monthlyUsage1;
		private int monthlyUsage2;
		private int monthlyUsage3;

		//Constructor
		public ICETask2(string customerId, int monthlyUsage1, int monthlyUsage2, int monthlyUsage3)
		{
			this.customerId = customerId;
			this.monthlyUsage1 = monthlyUsage1;
			this.monthlyUsage2 = monthlyUsage2;
			this.monthlyUsage3 = monthlyUsage3;
		}

		//Method to calculate the total monthly water usage
		public int CalculateTotal()
		{
			return monthlyUsage1 + monthlyUsage3 + monthlyUsage3;
		}

		//Method to calculate the average monthly water usage
		public double CalculateAverage()
		{
			return CalculateTotal() / 3.0;
		}
	}
}

/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */
