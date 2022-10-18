using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//等腰星形三角形
			//    *    
			//   ***
			//  *****
			// *******
			//*********

			for (int i=0 ;i<5; i++)
			{
				string countOfStar = new string('*', (i *2)+ 1);
				string countOfEmpty = new string(' ', 6- i);
				Console.WriteLine(countOfEmpty+countOfStar+countOfEmpty);
			}
			Console.ReadKey();
		}
	}
}
