using System;
namespace ProjectEuler {
	public class Problem3_2 {

		public static void Run () {
			long value = 600851475143;
			Console.WriteLine (Solve (value));
		}

		private static long Solve (long value) {
			for (int i = 2; i < value; i++) {
				while (value % i == 0) {
					if (value == i)
						return value;
					value /= i;
				}
			}
			return value;
		}
	}
}

