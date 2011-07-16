using System;
using System.Linq;

namespace ProjectEuler
{
	public class Problem1 {

		public static void Run() {
			int value = Enumerable.Range(0, 1000)
					.Where(n => n % 3 == 0 || n % 5 == 0)
					.Aggregate((num, sum) => num + sum);
			Console.WriteLine (value);
		}
	}
}

