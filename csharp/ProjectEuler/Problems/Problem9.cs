using System;
using System.Linq;

namespace ProjectEuler {
	public class Problem9 {
		public static void Run () {
			int value = (
				from a in Enumerable.Range (1, 1000 / 2)
				from b in Enumerable.Range (1, a)
				let c = 1000 - (a + b)
				where a * a + b * b == c * c
				select a * b * c).FirstOrDefault ();
			
			Console.WriteLine (value);
		}
	}
}

