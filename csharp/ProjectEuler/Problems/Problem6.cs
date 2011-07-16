using System;
using System.Linq;

namespace ProjectEuler {
	public class Problem6 {
		public static void Run () {
			int value = (
				from x in Enumerable.Range (1, 100)
				from y in Enumerable.Range (1, x - 1)
				select x * y).Aggregate ((x, y) => x + y) * 2;
			Console.WriteLine (value);
		}

	}
}

