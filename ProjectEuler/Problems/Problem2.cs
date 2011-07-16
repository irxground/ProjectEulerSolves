using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler {
	public class Problem2 {

		public static void Run() {
			var value = Fibonacci()
				.TakeWhile(num => num < 4 * 1000 * 1000)
				.Where(num => num % 2 == 0)
				.Aggregate((num, sum) => num + sum);
			Console.WriteLine (value);
		}

		public static IEnumerable<int> Fibonacci() {
			int a = 0;
			int b = 1;
			while(true) {
				int sum = a + b;
				yield return sum;
				a = b;
				b = sum;
			}
		}

	}
}

