using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PROG6221_ICETASK_2_ST10404816_Lisha_Naidoo
{
	internal class ICETask2
	{
		public static void calculate(string n)
		{
			double num1=0;
			double num2=0;
			double result;
			bool end=false;

			while (end != true)
			{
				int i = 0;
				if((double.TryParse(n.Substring(i, 1), out num1)==true))
				{
					i++;
					if ((double.TryParse(n.Substring(i, 1), out num2) == true))
					{
						end = true;
					}
					else
					{
						double.TryParse(n.Substring(i+1, 1), out num2);
						end = true;
					}
				}
				i++;
			}

			if (n.Contains('+'))
			{
				
				result = num1 + num2;
				Console.WriteLine(num1 + " + " + num2 + " = " + result);

			}
			else if (n.Contains('-'))
			{

				result = num1 - num2;
				Console.WriteLine(num1 + " - " + num2 + " = " + result);

			}
			else if (n.Contains('*'))
			{

				result = num1 * num2;
				Console.WriteLine(num1 + " x " + num2 + " = " + result);

			}
			else if (n.Contains('/'))
			{
				if(num2 == 0)
				{
					Console.WriteLine("Error: Cannot divide by 0");
				}
				else
				{
					result = num1 / num2;
					Console.WriteLine(num1 + " ÷ " + num2 + " = " + result);
				}
			}

		}

		}



	}
}
		

/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */
