using System;
namespace ProjectEuler {
	public class Problem5 {

		public static void Run () {
			int num = 1;
			for (int i = 2; i <= 20; i++) {
				num = Lcm (i, num);
			}
			Console.WriteLine (num);
		}

		private static int Gcd (int a, int b) {
			while (b != 0) {
				int tmp = a % b;
				a = b;
				b = tmp;
			}
			return a;
		}

		private static int Lcm (int a, int b) {
			int gcd = Gcd (a, b);
			return a / gcd * b;
		}
	}
}

