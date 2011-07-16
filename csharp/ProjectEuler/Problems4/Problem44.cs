using System;
namespace ProjectEuler {
	public class Problem44 {

		public static void Run () {
			long diff = Solve();
			Console.WriteLine(diff);
		}

		public static long Solve () {

			int num = 0;
			while (true) {
				Console.Write(">");
				num++;
				long p = P(num);
				int small_num = 1;
				int big_num = num + 1;
				long small = P(small_num);
				long big = P(big_num);
				while (small_num < big_num) {
					if (big - small == p) {
						if (IsP(big + small))
							return p;
						small_num++;
						big_num++;
						small = P(small_num);
						big = P(big_num);
					}
					else if (big - small > p) {
						small_num++;
						small = P(small_num);
					}
					else {
						big_num++;
						big = P(big_num);
					}
				}
			}

		}

		private static long P (int n) {
			return n * ((long)3 * n - 1) / 2;
		}

		private static bool IsP (long n) {
			int a = (int)Math.Sqrt(n * 2 / 3);
			return P(a) == n || P(a + 1) == n;
		}
	}
}

